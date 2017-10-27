using BCA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerGetAvatar : Packet
    {
        public PlayerInfo Player { get; set; }
        public int Id { get; set; }
    }
}
