using BCA.Network.Packets.Enums;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientChatMessage : Packet
    {
        public ChatMessageType Type { get; set; }
        public string Message { get; set; }
    }
}
