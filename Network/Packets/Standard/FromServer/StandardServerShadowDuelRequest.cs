using BCA.Common;
using BCA.Common.Bets;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerShadowDuelRequest : Packet
    {
        public PlayerInfo Player { get; set; }
        public RoomConfig Config { get; set; }
        public BetType BType { get; set; }
        public string BetSerealized { get; set; }
    }
}
