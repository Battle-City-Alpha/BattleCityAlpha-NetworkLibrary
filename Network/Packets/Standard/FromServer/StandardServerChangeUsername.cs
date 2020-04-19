using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerChangeUsername : Packet
    {
        public int PP { get; set; }
        public string Username { get; set; } // Change Username on client
    }
}
