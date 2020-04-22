namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientGiveTitle : Packet
    {
        public string Target { get; set; }
        public int TitleID { get; set; }
    }
}
