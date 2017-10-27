using BCA.Network.Packets.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Common
{
    public class PlayerInfo
    {
        public string Username { get; set; }
        public int UserId { get; set; }
        public string HID { get; set; }
        public PlayerRank Rank { get; set; }
        public PlayerState State { get; set; }
        public int ELO { get; set; }
    }
}
