using BCA.Common.Enums;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerGetBonus : Packet
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
        public int MonthlyConnectionNumber { get; set; }

        public int[] Cards { get; set; } // for booster bonus
    }
}
