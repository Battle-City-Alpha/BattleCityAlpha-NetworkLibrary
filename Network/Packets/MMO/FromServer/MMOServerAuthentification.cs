namespace BCA.Network.Packets.MMO.FromServer
{
    public class MMOServerAuthentification : Packet
    {
        public bool Success;

        public MMOServerAuthentification(bool success)
        {
            Success = success;
        }
    }
}
