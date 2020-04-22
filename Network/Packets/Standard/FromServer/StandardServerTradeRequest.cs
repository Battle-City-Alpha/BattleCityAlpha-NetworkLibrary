using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerTradeRequest : Packet
    {
        public PlayerInfo Player { get; set; }
    }
}
