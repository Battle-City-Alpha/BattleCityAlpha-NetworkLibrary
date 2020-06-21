using BCA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerMutechat : Packet
    {
        public bool IsMuted { get; set; }
        public string Reason { get; set; }
        public PlayerInfo Sender { get; set; }
    }
}
