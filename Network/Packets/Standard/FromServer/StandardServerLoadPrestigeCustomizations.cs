using BCA.Common;
using BCA.Common.Enums;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerLoadPrestigeCustomizations : Packet
    {
        public Customization[] Customizations { get; set; }
        public CustomizationType CType { get; set; }
    }
}
