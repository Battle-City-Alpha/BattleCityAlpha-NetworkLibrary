using BCA.Network.Packets.Enums;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerRegister : Packet
    {
        public bool Success { get; set; }
        public RegisterFailReason Reason { get; set; }
    }
}
