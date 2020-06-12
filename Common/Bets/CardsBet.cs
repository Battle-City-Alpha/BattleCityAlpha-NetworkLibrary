using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Common.Bets
{
    public class CardsBet : Bet
    {
        public Dictionary<int, PlayerCard[]> Cards { get; set; }

        public CardsBet()
        {
            Cards = new Dictionary<int, PlayerCard[]>();
        }

        public void SetCards(PlayerCard[] cards, int userID)
        {
            if (!Cards.ContainsKey(userID))
                Cards.Add(userID, cards);
            else
                Cards[userID] = cards;
        }
    }
}
