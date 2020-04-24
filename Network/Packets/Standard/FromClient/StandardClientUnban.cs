using System;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientUnban : Packet
    {
        public string Target { get; set; }
    }
}
