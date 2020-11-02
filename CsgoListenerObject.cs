using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace remote_csgo
{
    public class CsgoListenerObject
    {
        public TcpClient Client = new TcpClient();
        public NetworkStream NetStream;
        public string Hostname { get; set; }
        public int Port { get; set; }

        public bool Closed = false;

        public void SendMessage(string Message)
        {
            try
            {
                Byte[] DataBytes = System.Text.Encoding.ASCII.GetBytes(Message + "\r");
                if (NetStream.CanWrite)
                {
                    NetStream.Write(DataBytes, 0, DataBytes.Length);
                }
            } catch (Exception e)
            {

            }
        }
       

        public void ListenerThread()
        {
            while (true)
            {
                if (Client == null || Closed)
                {
                    break;
                }
                else
                {
                    if (NetStream.DataAvailable)
                    {
                        Byte[] DataBytes = new Byte[256];
                        String responseData = String.Empty;
                        Int32 bytes = NetStream.Read(DataBytes, 0, DataBytes.Length);
                        responseData = System.Text.Encoding.ASCII.GetString(DataBytes, 0, bytes);
                        MainForm.AppendConsoleThread(this, responseData);
                        Console.WriteLine("Received: {0}", responseData);
                    }
                }
                
                Thread.Sleep(1);
            }
        }

        public void CloseConnection()
        {
            Closed = true;
            Client.Close();
        }




        public void Init()
        {
            try
            {
                Client.Connect(new IPEndPoint(IPAddress.Parse(Hostname), Port));
                NetStream = Client.GetStream();
                Thread Listener = new Thread(ListenerThread);
                Listener.SetApartmentState(ApartmentState.STA);
                Listener.Start();
            }
            catch (Exception){ 
            
            }
        }
        public CsgoListenerObject()
        {
            Init();
        }
        public CsgoListenerObject(ScanObject Input)
        {
            this.Hostname = Input.Hostname;
            this.Port = Input.Port;
            Init();
        }
        public override string ToString()
        {
            return Hostname + ":" + Port;
        }

    }
}
