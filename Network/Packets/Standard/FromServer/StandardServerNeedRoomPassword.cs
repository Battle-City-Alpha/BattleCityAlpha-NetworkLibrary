using BCA.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerNeedRoomPassword : Packet
    {
        public int RoomId { get; set; }
        public RoomType RoomType { get; set; }
    }
}
