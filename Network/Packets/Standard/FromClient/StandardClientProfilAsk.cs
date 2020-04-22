using BCA.Common;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientProfilAsk : Packet
    {
        public PlayerInfo Username { get; set; }
    }
}
