using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerLoadSleeves : Packet
    {
        public Customization[] Sleeves { get; set; }
    }
}
