using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerDisabledAccount : Packet
    {
        public string Player { get; set; }
        public string Reason { get; set; }
    }
}
