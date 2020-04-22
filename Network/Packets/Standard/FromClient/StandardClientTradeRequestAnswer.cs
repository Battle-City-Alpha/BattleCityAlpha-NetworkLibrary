using BCA.Common;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientTradeRequestAnswer : Packet
    {
        public bool Result { get; set; }
        public PlayerInfo Player { get; set; }
    }
}
