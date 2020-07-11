using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Common
{
    public class RankingTeamInfos
    {
        public int SingleWin { get; set; }
        public int SingleLose { get; set; }
        public int SingleDraw { get; set; }
        public int MatchWin { get; set; }
        public int MatchLose { get; set; }
        public int MatchDraw { get; set; }
        public int TagWin { get; set; }
        public int TagLose { get; set; }
        public int TagDraw { get; set; }
        public int RankingSingle { get; set; }
        public int RankingMatch { get; set; }
        public int RankingTag { get; set; }
        public int GlobalRanking { get; set; }
    }
}
