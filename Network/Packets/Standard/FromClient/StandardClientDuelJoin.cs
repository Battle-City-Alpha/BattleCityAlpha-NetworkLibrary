using BCA.Common.Enums;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientDuelJoin : Packet
    {
        public int Id { get; set; }
        public RoomType RoomType { get; set; }
        public string RoomPass { get; set; }
    }
}
