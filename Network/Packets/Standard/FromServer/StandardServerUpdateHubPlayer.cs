using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerUpdateHubPlayer : Packet
    {
        public PlayerInfo Player { get; set; }
    }
}
