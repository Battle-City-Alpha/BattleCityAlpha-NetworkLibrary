using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Enums
{
    public enum CommandErrorType
    {
        SmallRank,
        NotVip,
        ArgTooLong,
        UnknownError,
        NoError,
        PlayerNotConnected,
        NotEnoughMoney,
        PlayerNotExisted,
        CardNotOwned,
        AvatarNotOwned,
        PriceUpTo0,
        AlreadyInDuel,
        PlayerNotInDuel,
        QuantityUpTo0,
        TitleNotOwned,
        InvalidRoomPass,
        CannotPlayAgainstYourself,
        OpponentDisconnected
    }
}
