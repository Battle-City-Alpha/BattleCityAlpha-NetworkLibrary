using BCA.Network.Packets.Enums;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerDataRetrieval : Packet
    {
        public bool Success { get; set; }
        public LoginFailReason Reason { get; set; }
        public bool End { get; set; }
    }
}
