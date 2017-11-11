using BCA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientTradeRequestAnswer : Packet
    {
        public bool Result { get; set; }
        public PlayerInfo Player { get; set; }
    }
}
