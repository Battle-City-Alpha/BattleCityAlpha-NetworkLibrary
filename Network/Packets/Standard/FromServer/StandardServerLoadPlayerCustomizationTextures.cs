using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerLoadPlayerCustomizationTextures : Packet
    {
        public Customization Avatar { get; set; }
        public Customization Border { get; set; }
        public Customization Sleeve { get; set; }
        public Customization Partner { get; set; }
        public int Pos { get; set; }
    }
}
