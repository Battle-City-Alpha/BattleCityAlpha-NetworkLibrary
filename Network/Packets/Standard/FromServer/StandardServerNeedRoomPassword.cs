using BCA.Common.Enums;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerNeedRoomPassword : Packet
    {
        public int RoomId { get; set; }
        public RoomType RoomType { get; set; }
    }
}
