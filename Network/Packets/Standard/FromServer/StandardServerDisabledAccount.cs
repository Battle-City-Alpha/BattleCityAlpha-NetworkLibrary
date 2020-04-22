namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerDisabledAccount : Packet
    {
        public string Player { get; set; }
        public string Reason { get; set; }
    }
}
