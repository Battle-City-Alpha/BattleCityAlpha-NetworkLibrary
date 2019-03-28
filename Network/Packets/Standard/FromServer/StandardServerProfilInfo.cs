using BCA.Network.Packets.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerProfilInfo : Packet
    {
        public string Username { get; set; }
        public int AvatarId { get; set; }
        public int CardNumber { get; set; }
        public int Level { get; set; }
        public int Exp { get; set; }
        public int RankedWin { get; set; }
        public int RankedLose { get; set; }
        public int ELO { get; set; }
        public PlayerRank Rank { get; set; }
        public int UnrankedWin { get; set; }
        public int UnrankedLose { get; set; }
        public int RageQuit { get; set; }
        public int GiveUp { get; set; }
    }
}
