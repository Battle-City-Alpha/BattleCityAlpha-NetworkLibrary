using System.Collections.Generic;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerSearchCard : Packet
    {
        public List<string> Boosters { get; set; }
    }
}
