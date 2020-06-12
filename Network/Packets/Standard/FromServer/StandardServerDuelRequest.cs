﻿using BCA.Common;
using BCA.Common.Bets;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerDuelRequest : Packet
    {
        public PlayerInfo Player { get; set; }
        public RoomConfig Config { get; set; }
        public string RoomPass { get; set; }
        public Bet Bet { get; set; }
    }
}
