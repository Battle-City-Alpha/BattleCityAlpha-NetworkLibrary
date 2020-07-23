namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientChangeTeamLeader : Packet
    {
        public string Target { get; set; }
    }
}
