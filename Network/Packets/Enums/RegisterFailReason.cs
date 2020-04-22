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
        Banned,
        NotEnoughMoney
    }
}
