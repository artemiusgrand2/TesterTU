using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.ComponentModel;

using TesterTU.Models;
using DataStream.SP;

namespace TesterTU.Controllers
{
    public class ControllerMain :IDisposable
    {
        ModelCommon _model;
        IList<SerialPortDataStream> _dataStreams = new List<SerialPortDataStream>();
        IList<Thread> _threadMKs = new List<Thread>();
        public bool IsStart { get; private set; }

        public ControllerMain(ModelCommon model)
        {
            _model = model;
        }
        public void Start()
        {
            Initialization();
            IsStart = true;
            foreach (var thr in _threadMKs)
                thr.Start(_threadMKs.IndexOf(thr));
        }
        public void Stop()
        {
            IsStart = false;
            foreach(var device in _model.Devices)
            {
                foreach (var mk in device.MKs)
                {
                    mk.Attempts = 0;
                    mk.Sessions = 0;
                    mk.Errors = 0;
                    //
                    foreach(var output in mk.Outputs)
                        output.Value = 0;
                }
            }
        }

        public void Dispose()
        {
            foreach (var stream in _dataStreams)
                stream.Dispose();
            //
            _dataStreams.Clear();
            _threadMKs.Clear();
        }

        private void WorkMK(object numberMK)
        {
            var indexDevice = 0;
            while (IsStart)
            {
                if (indexDevice >= _model.Devices.Count)
                    indexDevice = 0;
                try
                {
                    _model.Devices[indexDevice].MKs[(int)numberMK].Attempts++;
                    if (_dataStreams[(int)numberMK].Write(_model.Devices[indexDevice].MKs[(int)numberMK].RequestBytes) > 0)
                    {
                        byte[] dataRead;
                        if(_dataStreams[(int)numberMK].Read(out dataRead))
                            _model.Devices[indexDevice].MKs[(int)numberMK].ParseData(dataRead);
                    }
                }
                catch { }
                indexDevice++;
                Thread.Sleep(10);
            }
        }

        private void Initialization()
        {
            Dispose();
            foreach(var connection in _model.ConnectionStrs)
            {
                _dataStreams.Add(new SerialPortDataStream(connection));
                _threadMKs.Add(new Thread(WorkMK));
            }
        }
    }
}
