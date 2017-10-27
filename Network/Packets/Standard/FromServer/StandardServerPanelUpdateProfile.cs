using BCA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerPanelUpdateProfile : Packet
    {
        public string[] Accounts { get; set; }
        public string IP { get; set; }
        public string Observation { get; set; }
        public int Points { get; set; }
    }
}
