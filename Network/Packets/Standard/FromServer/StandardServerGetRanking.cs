using BCA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerGetRanking : Packet
    {
        public RankingPlayerInfos[] Rankings { get; set; }
        public Customization[] PodiumCustoms { get; set; }
    }
}
