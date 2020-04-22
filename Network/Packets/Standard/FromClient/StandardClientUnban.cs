using System;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientUnban : Packet
    {
        public String Target { get; set; }
    }
}
