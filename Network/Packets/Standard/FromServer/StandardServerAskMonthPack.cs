using BCA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerAskMonthPack : Packet
    {
        public int Avatar { get; set; }
        public int Border { get; set; }
        public int Sleeve { get; set; }
    }
}
