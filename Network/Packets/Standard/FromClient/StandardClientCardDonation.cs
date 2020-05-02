using BCA.Common;
using System.Collections.Generic;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientCardDonation : Packet
    {
        public Dictionary<int, PlayerCard> Cards { get; set; }
        public PlayerInfo Target { get; set; }
    }
}
