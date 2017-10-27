using BCA.Network.Packets.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerCommandError : Packet
    {
        public CommandErrorType Type { get; set; }
        public bool MessageBox { get; set; }
    }
}
