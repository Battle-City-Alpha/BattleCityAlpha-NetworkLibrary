using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerTradeMessage : Packet
    {
        public PlayerInfo Player { get; set; }
        public string Message { get; set; }
    }
}
