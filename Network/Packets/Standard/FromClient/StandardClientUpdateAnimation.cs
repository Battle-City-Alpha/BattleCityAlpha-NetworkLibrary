using BCA.Common;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientUpdateAnimation : Packet
    {
        public Animation Animation { get; set; }
        public bool Remove { get; set; }
        public int Offset { get; set; }
    }
}
