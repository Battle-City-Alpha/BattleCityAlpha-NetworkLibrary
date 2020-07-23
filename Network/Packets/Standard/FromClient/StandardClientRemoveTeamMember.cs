namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientRemoveTeamMember : Packet
    {
        public string Target { get; set; }
    }
}
