using BCA.Common;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientSpectate : Packet
    {
        public PlayerInfo Target { get; set; }
    }
}
