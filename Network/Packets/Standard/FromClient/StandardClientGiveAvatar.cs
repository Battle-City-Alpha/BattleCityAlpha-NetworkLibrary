namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientGiveAvatar : Packet
    {
        public string Target { get; set; }
        public int Avatar { get; set; }
    }
}
