using BCA.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientDuelJoin : Packet
    {
        public int Id { get; set; }
        public RoomType RoomType { get; set; }
        public string RoomPass { get; set; }
    }
}
