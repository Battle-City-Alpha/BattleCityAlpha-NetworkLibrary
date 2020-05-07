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
        public string CaptionText { get; set; }

        public bool IsCustom()
        {
            return (Banlist != 0 || (StartDuelLP != 8000 && Type != RoomType.Tag) || (StartDuelLP != 16000 && Type == RoomType.Tag) || CardByHand != 5 || MasterRules != 5 || DrawCount != 1 | NoShuffleDeck == true);
        }
    }
}
