using BCA.Common;
using System.Collections.Generic;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerLoadSelectCard : Packet
    {
        public Dictionary<int, PlayerCard> Collection { get; set; }
    }
}
