using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remote_csgo
{
    public class ScanObject
    {
        public string Hostname { get; set; }
        public int Port { get; set; }

        public bool IsOpen { get; set; } = false;
        public ScanObject()
        {

        }

        public ScanObject(string host, int port)
        {
            this.Hostname = host;
            this.Port = port;
        }
        public override string ToString()
        {
            return Hostname + ":" + Port;
        }
    }
}
