using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerOpenPrestigeShop : Packet
    {
        public int PP { get; set; }
        public int Progress { get; set; }
    }
}
