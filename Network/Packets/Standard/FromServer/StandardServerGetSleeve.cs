using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerGetSleeve : Packet
    {
        public PlayerInfo Player { get; set; }
        public int Id { get; set; }
    }
}
