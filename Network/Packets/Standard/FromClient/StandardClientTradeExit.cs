namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientTradeExit : Packet
    {
        public int Id { get; set; }
        public bool Validate { get; set; }
    }
}
