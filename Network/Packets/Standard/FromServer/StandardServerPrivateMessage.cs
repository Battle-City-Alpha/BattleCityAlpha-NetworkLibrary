using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerPrivateMessage : Packet
    {
        public PlayerInfo Player { get; set; }
        public string Message { get; set; }
    }
}
