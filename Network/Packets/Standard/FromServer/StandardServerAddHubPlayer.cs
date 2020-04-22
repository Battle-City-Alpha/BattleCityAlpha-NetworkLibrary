using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerAddHubPlayer : Packet
    {
        public PlayerInfo Infos { get; set; }
    }
}
