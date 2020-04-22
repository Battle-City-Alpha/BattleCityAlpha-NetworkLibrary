using BCA.Common;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientDonPoints : Packet
    {
        public PlayerInfo Target { get; set; }
        public int Amount { get; set; }
    }
}
