using BCA.Common;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientAskPanelProfile : Packet
    {
        public PlayerInfo Player { get; set; }
    }
}
