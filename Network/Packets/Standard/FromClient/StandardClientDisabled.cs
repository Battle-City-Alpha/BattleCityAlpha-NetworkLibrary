namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientDisabled : Packet
    {
        public string Target { get; set; }
        public string Reason { get; set; }
    }
}
