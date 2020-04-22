namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientGivePoints : Packet
    {
        public string Target { get; set; }
        public int Points { get; set; }
        public bool PrestigePoint { get; set; }
    }
}
