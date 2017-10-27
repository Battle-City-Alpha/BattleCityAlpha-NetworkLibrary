using BCA.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Common
{
    public class Room
    {
        public int Id { get; set; }
        public DuelType Type { get; set; }
        public PlayerInfo[] Players { get; set; }
        public List<PlayerInfo> Observers { get; set; }

        public Room(int id, DuelType type)
        {
            Id = id;
            Type = type;
            Players = new PlayerInfo[Type == DuelType.Tag ? 4 : 2];
        }

        public int AddPlayer(PlayerInfo player)
        {
            int pos = GetAvailablePlayerPos();
            if (pos != -1)
                Players[pos] = player;
            return pos;
        }

        public int RemovePlayer(PlayerInfo player)
        {
            int pos = GetPlayerPos(player);
            if (pos != -1)
                Players[pos] = null;
            return pos; 
        }

        private int GetPlayerPos(PlayerInfo player)
        {
            for (int i = 0; i < Players.Length; i++)
                if (Players[i] == player)
                    return i;
            return -1;
        }
        private int GetAvailablePlayerPos()
        {
            for (int i = 0; i < Players.Length; i++)
                if (Players[i] == null)
                    return i;
            return -1;
        }

        public bool IsRanked()
        {
            return Type == DuelType.Ranked;
        }
    }
}
