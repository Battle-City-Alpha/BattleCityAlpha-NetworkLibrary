namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientRegister : Packet
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string HID { get; set; }
    }
}
