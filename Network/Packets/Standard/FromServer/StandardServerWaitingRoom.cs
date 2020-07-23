using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerWaitingRoom : Packet
    {
        public Room WaitingRoom { get; set; }
    }
}
