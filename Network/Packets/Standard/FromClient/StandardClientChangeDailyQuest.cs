using BCA.Common.Enums;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientChangeDailyQuest : Packet
    {
        public DailyQuestType DQType { get; set; }
    }
}
