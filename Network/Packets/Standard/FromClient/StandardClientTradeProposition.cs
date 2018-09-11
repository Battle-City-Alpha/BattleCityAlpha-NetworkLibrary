using BCA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientTradeProposition : Packet
    {
        public int Id { get; set; }
        public List<PlayerCard> Cards { get; set; }
    }
}
