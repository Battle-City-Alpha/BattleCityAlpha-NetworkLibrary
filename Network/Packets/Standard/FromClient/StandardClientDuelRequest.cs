using BCA.Common;
using BCA.Common.Bets;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientDuelRequest : Packet
    {
        public int TargetId { get; set; }
        public RoomConfig Config { get; set; }
        public string RoomPass { get; set; }
    }
}
