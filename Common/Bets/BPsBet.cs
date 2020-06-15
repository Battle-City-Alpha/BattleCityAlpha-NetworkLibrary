using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Common.Bets
{
    public class BPsBet : Bet
    {
        public int Amount { get; set; }

        public BPsBet(int amount)
        {
            Amount = amount;
            this.BType = BetType.BPs;
        }
    }
}
