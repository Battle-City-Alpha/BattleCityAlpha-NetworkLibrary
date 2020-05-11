using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerShareReplay : Packet
    {
        public PlayerInfo Sender { get; set; }
        public byte[] ReplayFile { get; set; }
        public string ReplayName { get; set; }
    }
}
