using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerLoadPartners : Packet
    {
        public Customization[] Partners { get; set; }
    }
}
