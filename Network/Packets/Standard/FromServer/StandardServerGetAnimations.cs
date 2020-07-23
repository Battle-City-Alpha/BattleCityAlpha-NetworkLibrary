using BCA.Common;
using System.Collections.Generic;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerGetAnimations : Packet
    {
        public Dictionary<string, string> Colors { get; set; }
        public Animation[] Animations { get; set; }
    }
}
