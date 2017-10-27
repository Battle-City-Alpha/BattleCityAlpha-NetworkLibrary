using BCA.Common;
using BCA.Network.Packets.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerUpdateCollection : Packet
    {
        public Dictionary<int, PlayerCard> Collection { get; set; }
        public AskCollectionReason Reason { get; set; }
    }
}
