using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerRemoveHubPlayer : Packet
    {
        public PlayerInfo Infos { get; set; }
    }
}
