using System.Collections.Generic;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerLoadTitles : Packet
    {
        public Dictionary<int, string> Titles { get; set; }
    }
}
