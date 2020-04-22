namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientGiveSleeve : Packet
    {
        public string Target { get; set; }
        public int Sleeve { get; set; }
    }
}
