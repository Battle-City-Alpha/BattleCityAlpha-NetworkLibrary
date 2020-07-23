using BCA.Common.Enums;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerGetDailyQuestReward : Packet
    {
        public bool Success { get; set; }
        public DailyQuestType DQType { get; set; }
        public int Reward { get; set; }
        public bool AllQuests { get; set; }
    }
}
