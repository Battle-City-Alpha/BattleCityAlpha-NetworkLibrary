using BCA.Network.Packets.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerDataRetrieval : Packet
    {
        public bool Success { get; set; }
        public LoginFailReason Reason { get; set; }
        public bool End { get; set; }
    }
}
