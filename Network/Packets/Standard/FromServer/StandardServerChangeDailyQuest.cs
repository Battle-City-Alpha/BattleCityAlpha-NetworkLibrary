using BCA.Common.Enums;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerChangeDailyQuest : Packet
    {
        public bool Success { get; set; }
        public DailyQuestType DQType { get; set; }
        public string NewQuest { get; set; }
    }
}
