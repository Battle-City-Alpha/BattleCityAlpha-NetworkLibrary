using BCA.Common.Enums;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientRoomNeedPassword : Packet
    {
        public int RoomId { get; set; }
        public RoomType RoomType { get; set; }
        public string Roompass { get; set; }
    }
}
