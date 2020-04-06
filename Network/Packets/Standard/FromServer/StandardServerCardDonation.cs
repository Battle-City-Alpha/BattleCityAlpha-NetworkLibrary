using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerCardDonation : Packet
    {
        public PlayerInfo Player { get; set; }
        public int Id { get; set; }
        public int Quantity { get; set; }
    }
}
