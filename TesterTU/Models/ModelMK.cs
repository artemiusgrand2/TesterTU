using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

using TesterTU.Enums;
using TesterTU.Controllers;

namespace TesterTU.Models
{
    public  class ModelMK : INotifyPropertyChanged
    {
        int _attempts;
        public int Attempts
        {
            get
            {
                return _attempts;
            }
            set
            {
                _attempts = value;
                OnPropertyChanged("Attempts");
            }
        }

        int _sessions;
        public int Sessions
        {
            get
            {
                return _sessions;
            }
            set
            {
                _sessions = value;
                var delta = DateTime.Now - _lastSessions;
                if (_lastSessions != DateTime.MinValue)
                    Speed = delta.TotalMilliseconds;
                _lastSessions = DateTime.Now;
                OnPropertyChanged("Sessions");
            }
        }

        int _errors;
        public int Errors
        {
            get
            {
                return _errors;
            }
            set
            {
                _errors = value;
                OnPropertyChanged("Errors");
            }
        }

        double _speed;
        public double Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
                OnPropertyChanged("Speed");
            }
        }

        public int LenghtPacketAnswer
        {
            get
            {
                return _modelParent.View == ViewDevice.ts ? 12 : 9;
            }
        }


        private DateTime _lastSessions = DateTime.MinValue;

        private byte firstByteRequestTU = 0xD1;
        private byte firstByteRequestTS = 0xB1;

        //private byte firstByteAnswerTU = 0xD2;
        //private byte firstByteAnswerTS = 0xB2;

        public byte[] RequestBytes
        {
            get
            {
                var data = new byte[_modelParent.View == ViewDevice.tu ? 9 : 7];
                var bytesMK0 = BitConverter.GetBytes((ushort)(_modelParent.AdressMK0 << 1));
                var bytesMKn = BitConverter.GetBytes((ushort)(NumberMK == 1 ? _modelParent.AdressMK1 : _modelParent.AdressMK2) << 1);
                //
                for (var index = 0; index < data.Length - 2; index++)
                {
                    switch (index)
                    {
                        case 0:
                            {
                                data[index] = (byte)((_modelParent.View == ViewDevice.tu) ? firstByteRequestTU : firstByteRequestTS);
                            }
                            break;
                        case 1:
                            {
                                data[index] = (byte)(bytesMKn[1] & 127);
                            }
                            break;
                        case 2:
                            {
                                data[index] = (byte)((bytesMKn[0] >> 1) & 127);
                            }
                            break;
                        case 3:
                            {
                                data[index] = (byte)(bytesMK0[1] & 127);
                            }
                            break;
                        case 4:
                            {
                                data[index] = (byte)((bytesMK0[0] >> 1) & 127);
                            }
                            break;
                        case 5:
                            {
                                data[index] = ControllerHelper.GetByteFromBitArray((new BitArray(new bool[] {Outputs[4].IsOn, Outputs[5].IsOn, Outputs[6].IsOn, Outputs[7].IsOn,
                                                                 false, false, false, false })));
                            }
                            break;
                        case 6:
                            {
                                data[index] = ControllerHelper.GetByteFromBitArray((new BitArray(new bool[] {Outputs[0].IsOn, Outputs[1].IsOn, Outputs[2].IsOn, Outputs[3].IsOn,
                                                                   false , false , false ,false})));
                            }
                            break;
                    }
                }
                //
                var byteCRC = ControllerHelper.GetCRC8(data.Take(data.Length - 2).ToArray());
                data[data.Length - 2] = (byte)((byteCRC & 240) >> 4);
                data[data.Length - 1] = (byte)(byteCRC & 15);
                //
                return data;
            }
        }

        public int NumberMK { get; private set; }

        public IList<ModelOutput> Outputs { get; } = new List<ModelOutput>();

        public ModelDevice _modelParent;

        public ModelMK(ModelDevice modelDevice, int numberMK)
        {
            NumberMK = numberMK;
            _modelParent = modelDevice;
            //
            for (var index = 1; index <= (_modelParent.View == ViewDevice.ts ? 18 : 9); index++)
                Outputs.Add(new ModelOutput(index));
        }
        public void ParseData(byte [] data)
        {
            Sessions++;
            if (LenghtPacketAnswer != data.Length)
            {
                Errors++;
                return;
            }
            //
            var crc = (byte)(data[data.Length - 1] | (byte)(data[data.Length - 2] << 4));
            if(crc != ControllerHelper.GetCRC8(data.Take(data.Length - 2).ToArray()))
            {
                Errors++;
                return;
            }
            //
            if(_modelParent.View == ViewDevice.tu)
            {
                for(var index =0; index <= 6; index++)
                    Outputs[index].Value = (byte)((data[data.Length - 3] >> index) & 1);
                //
                for (var index = 0; index <= 1; index++)
                    Outputs[index + 7].Value = (byte)((data[data.Length - 4] >> index) & 1);
            }
            else
            {
                var numberOutPut = 0;
                var countBitValue = 0;
                byte bufferValue = 0;
                for (var index = data.Length - 3; index >= data.Length - 7; index--)
                {
                    for (var numBit = 0; numBit < 8; numBit++)
                    {
                        if (numberOutPut == 18)
                            break;
                        //
                        if (numberOutPut < 16)
                        {
                            if (numBit == 7)
                                continue;
                            if (countBitValue < 2)
                            {
                                if (countBitValue == 0)
                                    bufferValue = (byte)((data[index] >> numBit) & 1);
                                else
                                {
                                    Outputs[numberOutPut].Value = (byte)((((data[index] >> numBit) & 1) << 1) | bufferValue);
                                    numberOutPut++;
                                }
                                //
                                countBitValue++;
                            }
                            //
                            if (countBitValue == 2)
                                countBitValue = 0;
                        }
                        else
                        {
                            Outputs[numberOutPut].Value = (byte)((data[index] >> numBit) & 1);
                            numberOutPut++;
                        }
                    }
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
