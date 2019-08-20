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
        public int Id { get; private set; }
        public PlayerInfo[] Players { get; set; }
        public int[] ELOs { get; set; }
        public List<PlayerInfo> Observers { get; set; }
        public RoomConfig Config { get; set; }

        public Room(int id, RoomConfig config)
        {
            Id = id;
            Config = config;
            Players = new PlayerInfo[Config.Type == RoomType.Tag ? 4 : 2];
            ELOs = new int[Config.Type == RoomType.Tag ? 4 : 2];
        }

        public int AddPlayer(PlayerInfo player, int elo)
        {
            int pos = GetAvailablePlayerPos();
            if (pos != -1)
            {
                Players[pos] = player;
                ELOs[pos] = elo;
            }
            return pos;
        }

        public int RemovePlayer(PlayerInfo player)
        {
            int pos = GetPlayerPos(player);
            if (pos != -1)
            {
                Players[pos] = null;
                ELOs[pos] = -1;
            }
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
            return Config.Ranked;
        }

        public int GetRules()
        {
            return (int)Config.Rules;
        }

        public int GetRoomType()
        {
            return (int)Config.Type;
        }

        public bool IsFull()
        {
            return GetAvailablePlayerPos() == -1;
        }
    }
}
