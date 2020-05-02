using BCA.Common;
using BCA.Network.Packets.Enums;
using System.Collections.Generic;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerLoadSelectCard : Packet
    {
        public Dictionary<int, PlayerCard> Collection { get; set; }
        public AskCollectionReason Reason { get; set; }
    }
}
