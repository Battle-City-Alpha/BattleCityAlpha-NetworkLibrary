using BCA.Common;
using BCA.Network.Packets.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientRanker : Packet
    {
        public PlayerInfo Player { get; set; }
        public PlayerRank Rank { get; set; }
    }
}
