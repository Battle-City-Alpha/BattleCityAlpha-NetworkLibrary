using BCA.Common;
using BCA.Network.Packets.Enums;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerProfilInfo : Packet
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Title { get; set; }
        public Customization Avatar { get; set; }
        public Customization Border { get; set; }
        public Customization Sleeve { get; set; }
        public int CardNumber { get; set; }
        public int Level { get; set; }
        public int Exp { get; set; }
        public int RankedWin { get; set; }
        public int RankedLose { get; set; }
        public int RankedDraw { get; set; }
        public int ELO { get; set; }
        public PlayerRank Rank { get; set; }
        public int SingleWin { get; set; }
        public int SingleLose { get; set; }
        public int SingleDraw { get; set; }
        public int MatchWin { get; set; }
        public int MatchLose { get; set; }
        public int MatchDraw { get; set; }
        public int TagWin { get; set; }
        public int TagLose { get; set; }
        public int TagDraw { get; set; }
        public int RageQuit { get; set; }
        public int GiveUp { get; set; }
        public int Ranking { get; set; }
    }
}
