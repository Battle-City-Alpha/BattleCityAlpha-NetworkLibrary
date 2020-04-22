namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientEnabled : Packet
    {
        public string Target { get; set; }
        public string Reason { get; set; }
    }
}
