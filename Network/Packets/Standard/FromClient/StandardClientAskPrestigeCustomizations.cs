using BCA.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientAskPrestigeCustomizations : Packet
    {
        public CustomizationType Ctype { get; set; }
    }
}
