using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerGetPoints : Packet
    {
        public PlayerInfo Player { get; set; }
        public int Points { get; set; }
        public bool PrestigePoints { get; set; }
    }
}
