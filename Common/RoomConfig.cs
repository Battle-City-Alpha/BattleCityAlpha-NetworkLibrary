using BCA.Common.Enums;

namespace BCA.Common
{
    public class RoomConfig
    {
        public RoomType Type { get; set; }
        public int Banlist { get; set; }
        public RoomRules Rules { get; set; }
        public int CardByHand { get; set; }
        public int StartDuelLP { get; set; }
        public bool Ranked { get; set; }
        public int MasterRules { get; set; }
        public int DrawCount { get; set; }
        public bool NoShuffleDeck { get; set; }
    }
}
