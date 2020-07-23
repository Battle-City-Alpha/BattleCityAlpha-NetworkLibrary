using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerGetTeamsRanking : Packet
    {
        public RankingTeamInfos[] Ranking { get; set; }
        public int Season { get; set; }
    }
}
