using BCA.Common;
using System.Collections.Generic;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerTradeProposition : Packet
    {
        public List<PlayerCard> Cards { get; set; }
    }
}
