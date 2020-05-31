using BCA.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
