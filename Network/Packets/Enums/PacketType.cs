using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Enums
{
    public enum PacketType
    {
        ChatMessage,
        Register,
        Login,
        AddHubPlayer,
        RemoveHubPlayer,
        PlayerList,
        CommandError,
        Kick,
        Ban,
        Mute
    }
}
