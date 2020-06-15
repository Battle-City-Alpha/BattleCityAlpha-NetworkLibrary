using BCA.Common.Enums;
using BCA.Common.Bets;
using System;
using System.Collections.Generic;
using System.Timers;
using Newtonsoft.Json;

namespace BCA.Common
{
    public class Room
    {
        public int Id { get; private set; }
        public bool NeedPassword { get; private set; }
        public PlayerInfo[] Players { get; set; }
        public int[] ELOs { get; set; }
        public List<PlayerInfo> Observers { get; set; }
        public RoomConfig Config { get; set; }
        public RoomState State { get; set; }
        public int Winner { get; set; }
        public bool IsRQorGiveUp { get; set; }

        public Customization[] Avatars { get; set; }
        public Customization[] Borders { get; set; }
        public Customization[] Sleeves { get; set; }
        public Customization[] Partners { get; set; }

        public event Action<Room> WaitingRoom;
        private Timer WaitingTimer;

        public BetType BType { get; set; }
        public string BetSerealized { get; set; }

        public Room(int id, RoomConfig config, bool needpassword)
        {
            Id = id;
            NeedPassword = needpassword;
            Config = config;
            Players = new PlayerInfo[Config.Type == RoomType.Tag ? 4 : 2];
            ELOs = new int[Config.Type == RoomType.Tag ? 4 : 2];
            Observers = new List<PlayerInfo>();
            State = RoomState.Waiting;
            IsRQorGiveUp = false;

            Avatars = new Customization[Config.Type == RoomType.Tag ? 4 : 2];
            Borders = new Customization[Config.Type == RoomType.Tag ? 4 : 2];
            Sleeves = new Customization[Config.Type == RoomType.Tag ? 4 : 2];
            Partners = new Customization[Config.Type == RoomType.Tag ? 4 : 2];

            WaitingTimer = new Timer();
            WaitingTimer.Interval = Config.Type == RoomType.Tag ? TimeSpan.FromMinutes(4).TotalMilliseconds : TimeSpan.FromMinutes(2).TotalMilliseconds;
            WaitingTimer.Elapsed += WaitingTimer_Elapsed;

            BetSerealized = "";
        }
        public void SetBet(Bet b, BetType btype)
        {
            BType = btype;
            BetSerealized = JsonConvert.SerializeObject(b);
        }
        public bool IsShadowRoom()
        {
            return BetSerealized != "";
        }

        private void WaitingTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            WaitingTimer.Enabled = false;
            if (State != RoomState.Waiting)
                return;

            bool seekPlayer = false;
            for (int i = 1; i < Players.Length; i++)
                if (Players[i] == null)
                {
                    seekPlayer = true;
                    break;
                }

            if (seekPlayer)
                WaitingRoom?.Invoke(this);
        }

        public void AddPlayer(int pos, PlayerInfo player, int elo, Customization avatar, Customization border, Customization sleeve, Customization partner)
        {
            if (pos == 0)
                WaitingTimer.Enabled = true;

            Players[pos] = player;
            ELOs[pos] = elo;
            Avatars[pos] = avatar;
            Borders[pos] = border;
            Sleeves[pos] = sleeve;
            Partners[pos] = partner;
        }
        public void RemovePlayer(int pos, PlayerInfo player)
        {
            if (State == RoomState.Waiting)
            {
                Players[pos] = null;
                ELOs[pos] = -1;
                Avatars[pos] = null;
                Borders[pos] = null;
                Sleeves[pos] = null;
                Partners[pos] = null;
            }
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
            State = RoomState.Dueling;
            WaitingTimer.Enabled = false;
        }
        public void EndGame(int winner)
        {
            State = RoomState.Finished;
            Winner = winner;
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
    }
}
