namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerAskMonthPack : Packet
    {
        public int Avatar { get; set; }
        public int Border { get; set; }
        public int Sleeve { get; set; }
    }
}
