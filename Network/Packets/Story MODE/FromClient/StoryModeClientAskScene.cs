using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Story_Mode.FromClient
{
    public class StoryModeClientAskScene : Packet
    {
        public int ArcID { get; set; }
    }
}
