namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerPurchaseItem : Packet
    {
        public int[] Cards { get; set; }
        public int Points { get; set; }
    }
}
