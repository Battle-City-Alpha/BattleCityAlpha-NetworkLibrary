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
        Banlist,
        EnabledAccount,
        DisabledAccount,
        Mute,
        PrivateMessage,
        Profil,
        UpdateCollection,
        DuelRequest,
        DuelRequestAnswer,
        DuelSeeker,
        UpdateRoom,
        AskBooster,
        PurchaseItem,
        Clear,
        MPAll,
        Panel,
        GivePoints,
        GiveCard,
        GiveAvatar,
        PanelUserlist,
        PanelUpdate,
        PanelAskProfile,
        Ranker,
        TradeRequest,
        TradeRequestAnswer,
        TradeMessage,
        TradeProposition,
        TradeExit,
        TradeAnswer,
        ChangeAvatar,
        LoadAvatar
    }
}