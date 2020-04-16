using BCA.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientRoomNeedPassword : Packet
    {
        public int RoomId { get; set; }
        public RoomType RoomType { get; set; }
        public string Roompass { get; set; }
    }
}
