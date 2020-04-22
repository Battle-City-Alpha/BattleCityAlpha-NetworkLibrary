namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerChangeUsername : Packet
    {
        public int PP { get; set; }
        public string Username { get; set; } // Change Username on client
    }
}
