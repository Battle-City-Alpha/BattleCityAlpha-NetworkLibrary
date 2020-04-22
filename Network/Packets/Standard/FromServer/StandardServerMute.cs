namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerMute : Packet
    {
        public string Muter { get; set; }
        public int Time { get; set; }
        public string Reason { get; set; }
    }
}
