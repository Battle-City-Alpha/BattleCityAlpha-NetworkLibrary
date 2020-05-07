using System;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerMuted : Packet
    {
        public DateTime End { get; set; }
    }
}
