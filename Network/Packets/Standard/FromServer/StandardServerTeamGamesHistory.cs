using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerTeamGamesHistory : Packet
    {
        public TeamGameResult[] Results { get; set; }
    }
}
