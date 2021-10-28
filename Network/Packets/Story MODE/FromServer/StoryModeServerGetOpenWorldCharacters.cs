using BCA.Story_Mode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Story_Mode.FromServer
{
    public class StoryModeServerGetOpenWorldCharacters : Packet
    {
        public OpenWorldCharacter[] Characters { get; set; }
    }
}
