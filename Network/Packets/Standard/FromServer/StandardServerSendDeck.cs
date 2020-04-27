using BCA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerSendDeck : Packet
    {
        public PlayerInfo Sender { get; set; }
        public string[] Deckfile { get; set; }
        public string Deckname { get; set; }
    }
}
