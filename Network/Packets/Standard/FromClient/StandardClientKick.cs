using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientKick : Packet
    {
        public string Target { get; set; }
        public string Reason { get; set; }
    }
}
