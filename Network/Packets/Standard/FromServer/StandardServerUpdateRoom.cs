using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerUpdateRoom : Packet
    {
        public Room Room { get; set; }
    }
}
