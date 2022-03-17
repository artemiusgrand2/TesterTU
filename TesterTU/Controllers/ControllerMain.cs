using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.ComponentModel;

using TesterTU.Models;

namespace TesterTU.Controllers
{
    public class ControllerMain :IDisposable
    {
        ModelCommon _model;
        IList<ControllerSerialPort> _dataStreams = new List<ControllerSerialPort>();
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
            foreach (var device in _model.Devices)
            {
                foreach (var mk in device.MKs)
                {
                    mk.Attempts = 0;
                    mk.Sessions = 0;
                    mk.Errors = 0;
                    //
                    foreach (var output in mk.Outputs)
                        output.Value = -1;
                }
            }
            foreach (var thr in _threadMKs)
                thr.Start(_threadMKs.IndexOf(thr));
        }
        public void Stop()
        {
            IsStart = false;
           
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
                    if (_dataStreams[(int)numberMK].Write(_model.Devices[indexDevice].MKs[(int)numberMK].RequestBytes) > 0)
                    {
                        _model.Devices[indexDevice].MKs[(int)numberMK].Attempts++;
                        byte[] dataRead;
                        var resultBuffer = new List<byte>();
                        while(_dataStreams[(int)numberMK].Read(out dataRead))
                            resultBuffer.AddRange(dataRead.ToList());
                        //
                        _model.Devices[indexDevice].MKs[(int)numberMK].ParseData(resultBuffer);
                    }
                }
                catch(Exception error)
                {

                }
                indexDevice++;
                Thread.Sleep((int)(100 / (double)_model.Devices.Count));
            }
        }

        private void Initialization()
        {
            Dispose();
            foreach(var connection in _model.ConnectionStrs)
            {
                _dataStreams.Add(new ControllerSerialPort(connection));
                _threadMKs.Add(new Thread(WorkMK));
                break;
            }
        }
    }
}
