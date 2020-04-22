using BCA.Common;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientPanelProfileUpdate : Packet
    {
        public PlayerInfo Player { get; set; }
        public string Observation { get; set; }
    }
}
