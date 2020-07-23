namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientGivePartner : Packet
    {
        public string Target { get; set; }
        public int Partner { get; set; }
    }
}
