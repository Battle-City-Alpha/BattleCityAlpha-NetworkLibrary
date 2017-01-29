using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientChatMessage : Packet
    {
        public string Message;

        public StandardClientChatMessage(string message)
        {
            Message = message;
        }
    }
}
