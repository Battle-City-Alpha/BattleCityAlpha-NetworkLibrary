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
        public int UserId { get; set; }
        public string Username { get; set; }
        public bool VIP { get; set; }
        public int ELO { get; set; }
        public int Level { get; set; }
        public PlayerRank Rank { get; set; }
        public PlayerState State { get; set; }
        public Room CurrentRoom { get; set; }
    }
}
