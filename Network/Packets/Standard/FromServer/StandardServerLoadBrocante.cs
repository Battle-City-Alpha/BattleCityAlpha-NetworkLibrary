﻿using BCA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerLoadBrocante : Packet
    {
        public List<BrocanteCard> Cards { get; set; }
        public int BattlePoints { get; set; }
    }
}