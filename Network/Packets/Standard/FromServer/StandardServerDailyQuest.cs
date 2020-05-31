using BCA.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerSendDailyQuests : Packet
    {
        public DailyQuestType[] DQTypes { get; set; }
        public string[] Quests { get; set; }
        public int[] States { get; set; }
    }
}
