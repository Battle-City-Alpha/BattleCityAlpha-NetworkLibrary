using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerAskBooster : Packet
    {
        public int CardGot { get; set; }
        public int TotalCard { get; set; }
        public int Price { get; set; }
        public int CardPerPack { get; set; }
        public int BattlePoints { get; set; }
    }
}
