using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerBan : Packet
    {
        public string Banner { get; set; }
        public int Time { get; set; }
        public string Reason { get; set; }
    }
}
