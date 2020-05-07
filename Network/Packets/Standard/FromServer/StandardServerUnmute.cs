using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerUnmute : Packet
    {
        public PlayerInfo Player { get; set; }
    }
}
