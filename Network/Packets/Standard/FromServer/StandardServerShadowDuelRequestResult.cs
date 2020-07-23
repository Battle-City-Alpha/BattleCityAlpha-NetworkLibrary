using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerShadowDuelRequestResult : Packet
    {
        public PlayerInfo Player { get; set; }
        public bool Result { get; set; }
    }
}
