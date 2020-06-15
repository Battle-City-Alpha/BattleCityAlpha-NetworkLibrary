using BCA.Common;
using BCA.Common.Bets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientShadowDuelAnswer : Packet
    {
        public bool Result { get; set; }
        public PlayerInfo Player { get; set; }
        public RoomConfig Config { get; set; }
        public BetType BType { get; set; }
        public string BetSerealized { get; set; }
    }
}
