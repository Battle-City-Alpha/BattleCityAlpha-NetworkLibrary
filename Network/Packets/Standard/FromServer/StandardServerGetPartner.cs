using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerGetPartner : Packet
    {
        public PlayerInfo Player { get; set; }
        public int Id { get; set; }
    }
}
