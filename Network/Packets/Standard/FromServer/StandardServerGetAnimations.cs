using BCA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerGetAnimations : Packet
    {
        public Dictionary<string, string> Colors { get; set; }
        public Animation[] Animations { get; set; }
    }
}
