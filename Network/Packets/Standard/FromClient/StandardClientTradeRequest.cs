using BCA.Common;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientTradeRequest : Packet
    {
        public PlayerInfo Player { get; set; }
    }
}
