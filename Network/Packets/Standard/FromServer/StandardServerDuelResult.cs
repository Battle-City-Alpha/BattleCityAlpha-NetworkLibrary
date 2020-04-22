namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerDuelResult : Packet
    {
        public int PointsGain { get; set; }
        public int ExpGain { get; set; }
        public bool Win { get; set; }
    }
}
