using BCA.Network.Packets.Enums;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientAskSelectCard : Packet
    {
        public AskCollectionReason Reason { get; set; }
    }
}
