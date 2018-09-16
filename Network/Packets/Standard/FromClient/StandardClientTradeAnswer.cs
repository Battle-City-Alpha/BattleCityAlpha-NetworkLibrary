using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientTradeAnswer : Packet
    {
        public int Id { get; set; }
        public bool Result { get; set; }
    }
}
