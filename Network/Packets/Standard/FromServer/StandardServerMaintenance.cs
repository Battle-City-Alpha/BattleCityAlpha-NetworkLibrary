namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerMaintenance : Packet
    {
        public string Reason { get; set; }
        public int TimeEstimation { get; set; }
    }
}
