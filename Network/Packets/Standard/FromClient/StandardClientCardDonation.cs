using BCA.Common;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientCardDonation : Packet
    {
        public PlayerCard Card { get; set; }
        public int Quantity { get; set; }
        public PlayerInfo Target { get; set; }
    }
}
