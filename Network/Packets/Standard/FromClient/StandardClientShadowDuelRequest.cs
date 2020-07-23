using BCA.Common;
using BCA.Common.Bets;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientShadowDuelRequest : Packet
    {
        public int TargetId { get; set; }
        public RoomConfig Config { get; set; }
        public BetType BType { get; set; }
        public string BetSerealized { get; set; }
    }
}
