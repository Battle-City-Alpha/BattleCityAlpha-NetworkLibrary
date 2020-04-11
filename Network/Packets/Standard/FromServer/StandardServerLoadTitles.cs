using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerLoadTitles : Packet
    {
        public Dictionary<int, string> Titles { get; set; }
    }
}
