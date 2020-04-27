using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Common
{
    public class RankingPlayerInfos
    {
        public int UserID { get; set; }
        public int Rank { get; set; }
        public string Username { get; set; }
        public int ELO { get; set; }
        public int RankedWin { get; set; }
        public int RankedLose { get; set; }
    }
}
