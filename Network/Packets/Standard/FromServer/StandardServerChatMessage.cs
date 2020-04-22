using BCA.Common;
using BCA.Network.Packets.Enums;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerChatMessage : Packet
    {
        public ChatMessageType Type { get; set; }
        public PlayerInfo Player { get; set; }
        public string Message { get; set; }
    }
}
