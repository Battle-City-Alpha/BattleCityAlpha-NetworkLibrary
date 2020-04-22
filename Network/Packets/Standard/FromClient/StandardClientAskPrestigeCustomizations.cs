using BCA.Common.Enums;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientAskPrestigeCustomizations : Packet
    {
        public CustomizationType Ctype { get; set; }
    }
}
