using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerLoadBorders : Packet
    {
        public Customization[] Borders { get; set; }
    }
}
