using BCA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerTradeRequestAnswer : Packet
    {
        public PlayerInfo Player { get; set; }
        public bool Result { get; set; }
        public int Id { get; set; }
        public Dictionary<int, PlayerCard>[] Collections { get; set;}
    }
}
