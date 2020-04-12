using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerOfflineMessages : Packet
    {
        public OfflineMessage[] Messages { get; set; }
    }
}
