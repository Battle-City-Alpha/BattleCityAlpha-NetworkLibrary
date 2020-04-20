using BCA.Common.Enums;
using BCA.Network.Packets.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerGetCustomizationAchievement : Packet
    {
        public CustomizationType CustomType { get; set; }
        public int Id { get; set; }
        public CustomizationAchievementType AchievementType { get; set; }
        public int Amount { get; set; }
        public string BoosterTag { get; set; }
    }
}
