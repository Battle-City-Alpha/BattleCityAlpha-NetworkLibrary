namespace BCA.Network.Packets.MMO.FromClient
{
    public class MMOClientAuthentification : Packet
    {
        public string Username;
        public string Password;

        public MMOClientAuthentification(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
