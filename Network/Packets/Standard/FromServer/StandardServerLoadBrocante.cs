using BCA.Common;
using System.Collections.Generic;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerLoadBrocante : Packet
    {
        public List<BrocanteCard> Cards { get; set; }
        public int BattlePoints { get; set; }
    }
}
