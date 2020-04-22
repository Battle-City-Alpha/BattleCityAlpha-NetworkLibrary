using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerPlayerlist : Packet
    {
        public PlayerInfo[] Userlist { get; set; }
    }
}
