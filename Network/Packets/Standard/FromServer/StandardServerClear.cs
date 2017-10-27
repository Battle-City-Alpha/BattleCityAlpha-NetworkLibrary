using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerClear : Packet
    {
        public string Username { get; set; }
        public string Reason { get; set; }
    }
}
