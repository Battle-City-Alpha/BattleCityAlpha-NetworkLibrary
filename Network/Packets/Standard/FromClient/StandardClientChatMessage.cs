using BCA.Network.Packets.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientChatMessage : Packet
    {
        public ChatMessageType Type { get; set; }
        public string Message { get; set; }
    }
}
