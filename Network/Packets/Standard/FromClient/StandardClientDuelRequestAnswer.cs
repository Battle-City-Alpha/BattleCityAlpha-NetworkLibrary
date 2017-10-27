using BCA.Common;
using BCA.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientDuelRequestAnswer : Packet
    {
        public bool Result { get; set; }
        public PlayerInfo Player { get; set; }
        public DuelType Type { get; set; }
    }
}
