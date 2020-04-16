using BCA.Common;
using BCA.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerUpdateRoom : Packet
    {
        public Room Room { get; set; }
    }
}
