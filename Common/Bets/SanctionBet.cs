namespace BCA.Common.Bets
{
    public class SanctionBet : Bet
    {
        public int Time { get; private set; }

        public SanctionBet(BetType bt, int time)
        {
            Time = time;
            this.BType = bt;
        }
    }
}
