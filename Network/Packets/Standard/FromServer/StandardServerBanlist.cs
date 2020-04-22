namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerBanlist : Packet
    {
        public string[] Players { get; set; }
    }
}
