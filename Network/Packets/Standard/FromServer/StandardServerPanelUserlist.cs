using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerPanelUserlist : Packet
    {
        public PlayerInfo[] Players { get; set; }
    }
}
