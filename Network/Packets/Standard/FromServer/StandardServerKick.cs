namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerKick : Packet
    {
        public string Kicker { get; set; }
        public string Reason { get; set; }
    }
}
