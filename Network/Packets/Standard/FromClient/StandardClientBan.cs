using BCA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientBan : Packet
    {
        public PlayerInfo Target { get; set; }
        public int Time { get; set; }
        public string Reason { get; set; }
    }
}
