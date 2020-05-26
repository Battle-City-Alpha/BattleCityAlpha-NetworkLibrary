using BCA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerGetMonthlyBonus : Packet
    {
        public Dictionary<int, MonthlyBonus> Bonus { get; set; }
        public int[] Cards;
        public int MonthlyConnectionNumber { get; set; }
    }
}
