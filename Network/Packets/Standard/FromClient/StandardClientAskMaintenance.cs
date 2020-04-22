namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientAskMaintenance : Packet
    {
        public string Reason { get; set; }
        public int TimeEstimation { get; set; }
    }
}
