using System;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientUnmute : Packet
    {
        public String Target { get; set; }
    }
}
