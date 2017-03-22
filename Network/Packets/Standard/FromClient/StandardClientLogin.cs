using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientLogin : Packet
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string HID { get; set; }
    }
}
