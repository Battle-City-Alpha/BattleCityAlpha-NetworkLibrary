namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientBuyBrocanteCard : Packet
    {
        public int BcId { get; set; }
        public int Number { get; set; }
    }
}
