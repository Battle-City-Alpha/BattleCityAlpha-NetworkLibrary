namespace BCA.Common
{
    public class PlayerCard : BasicCard
    {
        public int Quantity { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name + "(" + Quantity + ")";
        }
    }
}
