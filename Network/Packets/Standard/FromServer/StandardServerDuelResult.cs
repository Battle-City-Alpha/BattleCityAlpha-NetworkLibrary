using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerDuelResult : Packet
    {
        public int PointsGain { get; set; }
        public int ExpGain { get; set; }
        public bool Win { get; set; }
    }
}
