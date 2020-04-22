namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerClear : Packet
    {
        public string Username { get; set; }
        public string Reason { get; set; }
    }
}
