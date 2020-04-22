namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientGiveBorder : Packet
    {
        public string Target { get; set; }
        public int Border { get; set; }
    }
}
