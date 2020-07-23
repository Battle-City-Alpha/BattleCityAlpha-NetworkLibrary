using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerMutechat : Packet
    {
        public bool IsMuted { get; set; }
        public string Reason { get; set; }
        public PlayerInfo Sender { get; set; }
    }
}
