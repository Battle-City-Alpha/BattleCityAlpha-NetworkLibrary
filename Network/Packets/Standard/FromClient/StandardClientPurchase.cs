namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientPurchase : Packet
    {
        public string Tag { get; set; }
        public int NumberPacket { get; set; }
    }
}
