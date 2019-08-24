using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerDuelStart : Packet
    {
        public Room Room { get; set; }
    }
}
