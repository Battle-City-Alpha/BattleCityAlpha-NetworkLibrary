using BCA.Common.Enums;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerSendDailyQuests : Packet
    {
        public DailyQuestType[] DQTypes { get; set; }
        public string[] Quests { get; set; }
        public int[] States { get; set; }
    }
}
