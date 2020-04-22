using BCA.Common.Enums;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientBuyPrestigeCustomization : Packet
    {
        public CustomizationType CustomType { get; set; }
        public int Id { get; set; }
    }
}
