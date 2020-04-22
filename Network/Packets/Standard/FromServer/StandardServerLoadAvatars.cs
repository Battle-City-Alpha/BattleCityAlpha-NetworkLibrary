using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerLoadAvatars : Packet
    {
        public Customization[] Avatars { get; set; }
    }
}
