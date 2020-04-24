using BCA.Common;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientBan : Packet
    {
        public string Target { get; set; }
        public int Time { get; set; }
        public string Reason { get; set; }
    }
}
