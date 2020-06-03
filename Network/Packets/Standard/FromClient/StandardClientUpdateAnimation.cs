using BCA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientUpdateAnimation : Packet
    {
        public Animation Animation { get; set; }
        public bool Remove { get; set; }
    }
}
