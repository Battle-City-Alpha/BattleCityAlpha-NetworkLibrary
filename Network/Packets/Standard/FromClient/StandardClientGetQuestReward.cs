using BCA.Common.Enums;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientGetQuestReward : Packet
    {
        public DailyQuestType DQType { get; set; }
    }
}
