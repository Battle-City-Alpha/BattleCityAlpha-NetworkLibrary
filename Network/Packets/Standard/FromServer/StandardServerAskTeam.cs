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
        public int ID { get; set; }
        public string Emblem { get; set; }
        public string Name { get; set; }
        public int LeaderID { get; set; }
        public int ColeaderID { get; set; }
        public PlayerInfo[] Members { get; set; }
        public int Wins { get; set; }
        public int Loses { get; set; }
        public string Tag { get; set; }
        public int Rank { get; set; }
        public int Score { get; set; }
    }
}
