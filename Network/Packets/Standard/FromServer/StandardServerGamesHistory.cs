using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerGamesHistory : Packet
    {
        public RoomResult[] Results { get; set; }
    }
}
