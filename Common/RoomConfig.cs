using BCA.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Common
{
    public class RoomConfig
    {
        public RoomType Type { get; set; }
        public int Banlist { get; set; }
        public RoomRules Rules { get; set; }
        public int CardByHand { get; set; }
        public int StartDuelLP { get; set; }
        public bool Ranked { get; set; }
        public bool Link { get; set; }
    }
}
