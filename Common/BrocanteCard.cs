namespace BCA.Common
{
    public class BrocanteCard : BasicCard
    {
        public int BCId { get; set; }
        public int SellerId { get; set; }
        public string SellerName { get; set; }
        public int Price { get; set; }
        public string CardName { get; set; }
        public int Quantity { get; set; }
    }
}
