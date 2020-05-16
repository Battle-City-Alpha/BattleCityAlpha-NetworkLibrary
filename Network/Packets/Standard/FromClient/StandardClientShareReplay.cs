using BCA.Common;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientShareReplay : Packet
    {
        public PlayerInfo Target { get; set; }
        public byte[] ReplayFile { get; set; }
        public string ReplayName { get; set; }
    }
}
