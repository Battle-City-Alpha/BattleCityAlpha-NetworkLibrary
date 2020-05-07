using System;

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
