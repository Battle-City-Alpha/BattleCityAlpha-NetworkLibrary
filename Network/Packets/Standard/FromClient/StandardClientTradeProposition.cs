using BCA.Common;
using System.Collections.Generic;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientTradeProposition : Packet
    {
        public int Id { get; set; }
        public List<PlayerCard> Cards { get; set; }
    }
}
