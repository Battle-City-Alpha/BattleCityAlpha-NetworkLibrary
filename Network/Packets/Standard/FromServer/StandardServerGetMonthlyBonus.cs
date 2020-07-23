using BCA.Common;
using System.Collections.Generic;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerGetMonthlyBonus : Packet
    {
        public Dictionary<int, MonthlyBonus> Bonus { get; set; }
        public int[] Cards;
        public int MonthlyConnectionNumber { get; set; }
    }
}
