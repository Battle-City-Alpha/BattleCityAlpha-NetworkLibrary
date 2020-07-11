using BCA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerAskTeam : Packet
    {
        public string Name { get; set; }
        public int LeaderID { get; set; }
        public int ColeaderID { get; set; }
        public RankingTeamInfos RankingInfos { get; set; }
        public PlayerInfo[] Members { get; set; }
    }
}
