namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientCreateTeam : Packet
    {
        public string Name { get; set; }
        public string Tag { get; set; }
        public string Emblem { get; set; }
    }
}
