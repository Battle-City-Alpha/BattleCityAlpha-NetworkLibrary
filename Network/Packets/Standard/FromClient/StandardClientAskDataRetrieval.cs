namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientAskDataRetrieval : Packet
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
