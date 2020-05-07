using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerGetRanking : Packet
    {
        public RankingPlayerInfos[] Rankings { get; set; }
        public Customization[] PodiumCustoms { get; set; }
    }
}
