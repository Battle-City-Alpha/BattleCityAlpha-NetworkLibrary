using BCA.Common.Enums;

namespace BCA.Common
{
    public class MonthlyBonus
    {
        public BonusType Type { get; set; }
        public string Gift { get; set; }
        /* 
         * if BP/PP Gift = amount
         * Card = card id
         * Avatar/Border/Sleeve = perso id
         * Booster = booster names
         * Title = title
         */

        public int[] Cards { get; set; } // for booster bonus
    }
}
