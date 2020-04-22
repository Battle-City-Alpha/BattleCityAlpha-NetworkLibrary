using BCA.Common;
using BCA.Network.Packets.Enums;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientRanker : Packet
    {
        public PlayerInfo Player { get; set; }
        public PlayerRank Rank { get; set; }
    }
}
