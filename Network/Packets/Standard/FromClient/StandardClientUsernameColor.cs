using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientUsernameColor : Packet
    {
        public string ChatColor { get; set; }
    }
}
