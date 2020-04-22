using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerGetTitle : Packet
    {
        public string Title { get; set; }
        public PlayerInfo Player { get; set; }
    }
}
