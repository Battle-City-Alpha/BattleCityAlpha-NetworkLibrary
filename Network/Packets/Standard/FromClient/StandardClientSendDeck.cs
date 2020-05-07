using BCA.Common;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientSendDeck : Packet
    {
        public PlayerInfo Target { get; set; }
        public string[] Deckfile { get; set; }
        public string Deckname { get; set; }
    }
}
