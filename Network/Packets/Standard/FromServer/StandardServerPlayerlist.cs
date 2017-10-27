using BCA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerPlayerlist : Packet
    {
        public PlayerInfo[] Userlist { get; set; }
    }
}
