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
