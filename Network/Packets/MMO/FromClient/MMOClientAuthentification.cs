using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
