using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Enums
{
    public enum RegisterFailReason
    {
        Nothing,
        UsernameAlreadyUsed,
        InvalidUsername,
        EmailAlreadyUsed,
        InvalidEmail,
        UsernameTooLong,
        UnknownProblem,
        Banned
    }
}
