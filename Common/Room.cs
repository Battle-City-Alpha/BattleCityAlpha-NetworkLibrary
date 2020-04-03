using BCA.Common.Enums;
using BCA.Network.Packets.Enums;
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
        public int Winner { get; set; }

        public Room(int id, RoomConfig config)
        {
            Id = id;
            Config = config;
            Players = new PlayerInfo[Config.Type == RoomType.Tag ? 4 : 2];
            ELOs = new int[Config.Type == RoomType.Tag ? 4 : 2];
            Observers = new List<PlayerInfo>();
        }

        public void AddPlayer(int pos, PlayerInfo player, int elo)
        {
            Players[pos] = player;
            ELOs[pos] = elo;
        }
        public void RemovePlayer(int pos, PlayerInfo player)
        {
            Players[pos] = null;
            ELOs[pos] = -1;
        }        

        public void AddSpectator(PlayerInfo info)
        {
            Observers.Add(info);
        }
        public void RemoveSpectator(PlayerInfo info)
        {
            Observers.Remove(info);
        }

        public void StartGame()
        {
            foreach (PlayerInfo info in Players)
            {
                info.State = PlayerState.Duel;
                info.CurrentRoom = this;
            }
        }
        public void EndGame(int winner)
        {
            Winner = winner;
            foreach (PlayerInfo info in Players)
            {
                info.State = PlayerState.Lobby;
                info.CurrentRoom = null;
            }
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
        public PlayerInfo GetPlayer(string name)
        {
            for (int i = 0; i < Players.Length; i++)
                if (Players[i].Username == name)
                    return Players[i];
            return null;
        }

        #region "Old functions"
        /*
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
        public bool IsFull()
        {
            return GetAvailablePlayerPos() == -1;
        }
         */
        #endregion
    }
}
