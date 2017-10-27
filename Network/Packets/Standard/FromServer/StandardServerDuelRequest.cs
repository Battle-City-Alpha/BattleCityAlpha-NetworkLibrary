﻿using BCA.Common;
using BCA.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerDuelRequest : Packet
    {
        public PlayerInfo Player { get; set; }
        public DuelType Type { get; set; }
    }
}