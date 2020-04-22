namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientGiveCard : Packet
    {
        public string Target { get; set; }
        public int Id { get; set; }
    }
}
