using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerPanelUpdateProfile : Packet
    {
        public PlayerInfo Profil { get; set; }
        public string[] Accounts { get; set; }
        public string IP { get; set; }
        public string Observation { get; set; }
        public int Points { get; set; }
    }
}
