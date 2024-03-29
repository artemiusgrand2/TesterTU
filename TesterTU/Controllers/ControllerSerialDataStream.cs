﻿using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.IO.Ports;
using System.Threading;

using TesterTU.Interfaces;

namespace TesterTU.Controllers
{
    public class ControllerSerialDataStream : IControllerDataStream
    {
        private const int DefaultReadTimeout = 20;

        private readonly byte[] buffer = new byte[1024 * 1024];

        private readonly string portName;
        private readonly int baudRate;
        private SerialPort port;


        public ControllerSerialDataStream(string connectionString)
        {
            string[] parts = connectionString.Split(':');
            if (parts.Length != 2)
            {
                throw new ArgumentException("Invalid connection string");
            }

            portName = parts[0];
            baudRate = int.Parse(parts[1]);

            CheckIfPortExists();
            InitPort();
        }

        private void CheckIfPortExists()
        {
            foreach (string name in SerialPort.GetPortNames())
            {
                if (name == portName)
                {
                    return;
                }
            }
            throw new InvalidDataException(string.Format("Port with name \"{0}\" doesn't exist", portName));
        }


        private void InitPort() 
        {
            port = new SerialPort(portName, baudRate);
            //port.WriteTimeout = 2;
           // port.ReadTimeout = DefaultReadTimeout;
        }

        private void Open()
        {
            port.Open();
        }

        public bool Read(out byte[] data, int lengtData)
        {
            lock (port)
            {
                data = null;
                var startRead = DateTime.Now;
                while (true)
                {
                    try
                    {
                        if ((DateTime.Now - startRead).TotalMilliseconds >= DefaultReadTimeout)
                            return false;
                        if (port.BytesToRead < lengtData)
                            continue;
                        int recieved = port.Read(buffer, 0, buffer.Length);
                        if (recieved == 0)
                            return false;
                        //
                        data = buffer.Take(recieved).ToArray();
                        return true;
                    }
                    catch (TimeoutException)
                    {
                        return false;
                    }
                    catch (InvalidOperationException)
                    {
                        if (port.IsOpen)
                        {
                            port.Close();
                        }
                        InitPort();
                        Open();
                    }
                }
            }
        }

        public int Write(byte[] data)
        {
            lock (port)
            {
                try
                {
                    port.Write(data, 0, data.Length);
                    return data.Length;
                }
                catch (TimeoutException)
                {
                    return 0;
                }
                catch (InvalidOperationException error)
                {
                    if (port.IsOpen)
                    {
                        port.Close();
                    }
                    InitPort();
                    Open();
                }
            }
            //
            return 0;
            // throw new NotImplementedException();
        }

        public void Dispose()
        {
            lock (port)
            {
                if (port.IsOpen)
                {
                    port.Close();
                }
            }
        }
    }
}
