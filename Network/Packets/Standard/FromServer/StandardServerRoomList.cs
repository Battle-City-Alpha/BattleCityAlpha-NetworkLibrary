using BCA.Common;
using BCA.Common.Enums;
using System.Collections.Generic;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerRoomList : Packet
    {
        public Dictionary<RoomState, Room[]> Rooms { get; set; }
    }
}
