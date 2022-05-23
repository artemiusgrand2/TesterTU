using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Linq;
using System.Threading;

using TesterTU.Interfaces;

namespace TesterTU.Controllers
{
    public class ControllerTcpDataStream : IControllerDataStream
    {
        private const int DefaultReadTimeout = 150;

        private readonly byte[] buffer = new byte[1024 * 512];
        private Socket socket;
        private IPEndPoint endPoint;
        private bool wasConnected;


        public ControllerTcpDataStream(string connectionString)
        {
            var parts = connectionString.Split(':');
            if (parts.Length != 2)
                throw new ArgumentException(string.Format("Connection string has invalid format {0}", connectionString));

            IPAddress ip;
            if (!IPAddress.TryParse(parts[0], out ip))
                throw new ArgumentException(string.Format("IP-address has invalid format"));

            int port;
            if (!int.TryParse(parts[1], out port))
                throw new ArgumentException(string.Format("Listen port has invalid format"));

            endPoint = new IPEndPoint(ip, port);
            CreateSocket();
        }

        private void CreateSocket()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // socket.ReceiveTimeout = 2000;
            socket.SendTimeout = 1000;
            wasConnected = false;
        }


        public bool Read(out byte[] data, int lengtData)
        {
            lock (socket)
            {
                data = null;
                var startRead = DateTime.Now;
                while (true)
                {
                    try
                    {
                        if ((DateTime.Now - startRead).TotalMilliseconds >= DefaultReadTimeout)
                            return false;
                        //
                        if (socket.Available < lengtData)
                            continue;
                        //
                        var recieved = socket.Receive(buffer);
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
                    catch (SocketException)
                    {
                        ReConnect();
                        return false;
                    }
                }
            }
        }

        public int Write(byte[] data)
        {
            lock (socket)
            {
                while (true)
                {
                    try
                    {
                        int sent = socket.Send(data);
                        return sent;
                    }
                    catch (SocketException)
                    {
                        ReConnect();
                    }
                }
            }
        }

        public void ReConnect()
        {
            if (wasConnected)
            {
                TryDisconnect(true);
                TryShutdown(SocketShutdown.Both);
                socket.Close();
                CreateSocket();
            }
            //
            Connect();
        }

        public int Write(IList<byte[]> data)
        {
            return 0;
        }

        public void Dispose()
        {
            lock (socket)
            {
                TryShutdown(SocketShutdown.Both);
                TryDisconnect(false);
                socket.Close();
            }
        }

        private void Connect()
        {
            if (!wasConnected)
            {
                socket.Connect(endPoint);
                wasConnected = true;
            }
        }

        private void TryDisconnect(bool reuse)
        {
            try
            {
                socket.Disconnect(reuse);
            }
            catch
            { }
        }

        private void TryShutdown(SocketShutdown socketShutdown)
        {
            try
            {
                socket.Shutdown(socketShutdown);
            }
            catch
            { }
        }
    }
}
