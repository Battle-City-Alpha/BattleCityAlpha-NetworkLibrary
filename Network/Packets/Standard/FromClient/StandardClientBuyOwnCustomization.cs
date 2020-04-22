using BCA.Common.Enums;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientBuyOwnCustomization : Packet
    {
        public CustomizationType CustomType { get; set; }
        public string URL { get; set; }
    }
}
