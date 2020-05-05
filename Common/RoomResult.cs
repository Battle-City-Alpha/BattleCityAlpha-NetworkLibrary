using BCA.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Common
{
    public class RoomResult
    {
        public PlayerInfo Opponent { get; set; }
        public int ELO { get; set; }
        public int CurrentRank { get; set; }
        public int TotalRank { get; set; }
        public DateTime GameDate { get; set; }
    }
}
