using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerMute : Packet
    {
        public string Muter { get; set; }
        public int Time { get; set; }
        public string Reason { get; set; }
    }
}
