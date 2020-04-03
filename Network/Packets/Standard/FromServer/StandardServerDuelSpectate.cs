using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerDuelSpectate : Packet
    {
        public Room Room { get; set; }
    }
}
