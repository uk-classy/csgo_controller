using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace remote_csgo
{
    public static class NetScanManager
    {

        public static TcpClient Client = new TcpClient();

        public static bool IsPortOpen(string Hostname, int Port)
        {
            try
            {
                Client = new TcpClient();
                Client.Connect(new IPEndPoint(IPAddress.Parse (Hostname) , Port));
                Client.Close();
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }
    }
}
