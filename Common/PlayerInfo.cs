using BCA.Network.Packets.Enums;

namespace BCA.Common
{
    public class PlayerInfo
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string ChatColorString { get; set; }
        public bool VIP { get; set; }
        public int ELO { get; set; }
        public int Level { get; set; }
        public PlayerRank Rank { get; set; }
        public PlayerState State { get; set; }
        public Customization Avatar { get; set; }

        public override string ToString()
        {
            return Username;
        }
    }
}
