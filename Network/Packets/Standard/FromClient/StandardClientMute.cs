﻿using BCA.Common;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientMute : Packet
    {
        public PlayerInfo Target { get; set; }
        public int Time { get; set; }
        public string Reason { get; set; }
    }
}
