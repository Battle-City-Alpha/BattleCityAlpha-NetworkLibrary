using BCA.Network.Packets.Enums;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerCommandError : Packet
    {
        public CommandErrorType Type { get; set; }
        public bool MessageBox { get; set; }
    }
}
