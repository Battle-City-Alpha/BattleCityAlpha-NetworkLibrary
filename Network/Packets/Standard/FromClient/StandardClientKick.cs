using BCA.Common;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientKick : Packet
    {
        public PlayerInfo Target { get; set; }
        public string Reason { get; set; }
    }
}
