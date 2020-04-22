namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientTradeMessage : Packet
    {
        public int Id { get; set; }
        public string Message { get; set; }
    }
}
