using BCA.Common;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientDuelHost : Packet
    {
        public RoomConfig Config { get; set; }
        public string RoomPass { get; set; }
    }
}
