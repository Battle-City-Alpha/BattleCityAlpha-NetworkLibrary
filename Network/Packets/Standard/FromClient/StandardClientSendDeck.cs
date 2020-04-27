using BCA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientSendDeck : Packet
    {
        public PlayerInfo Target { get; set; }
        public string[] Deckfile { get; set; }
        public string Deckname { get; set; }
    }
}
