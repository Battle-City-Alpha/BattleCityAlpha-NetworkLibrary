using BCA.Common;
using System.Collections.Generic;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerCardDonation : Packet
    {
        public PlayerInfo Player { get; set; }
        public Dictionary<int, PlayerCard> Cards { get; set; }
    }
}
