using BCA.Common;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientDuelRequestAnswer : Packet
    {
        public bool Result { get; set; }
        public PlayerInfo Player { get; set; }
        public RoomConfig Config { get; set; }
        public string Roompass { get; set; }
    }
}
