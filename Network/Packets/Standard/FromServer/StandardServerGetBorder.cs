using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerGetBorder : Packet
    {
        public PlayerInfo Player { get; set; }
        public int Id { get; set; }
    }
}
