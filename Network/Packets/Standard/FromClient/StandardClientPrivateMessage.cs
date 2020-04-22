using BCA.Common;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientPrivateMessage : Packet
    {
        public PlayerInfo Target { get; set; }
        public string Message { get; set; }
    }
}
