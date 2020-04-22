namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientTradeAnswer : Packet
    {
        public int Id { get; set; }
        public bool Result { get; set; }
    }
}
