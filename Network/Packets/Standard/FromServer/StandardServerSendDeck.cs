using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerSendDeck : Packet
    {
        public PlayerInfo Sender { get; set; }
        public string[] Deckfile { get; set; }
        public string Deckname { get; set; }
    }
}
