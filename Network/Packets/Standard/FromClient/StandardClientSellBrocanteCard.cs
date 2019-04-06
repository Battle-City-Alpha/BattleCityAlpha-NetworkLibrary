﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientSellBrocanteCard : Packet
    {
        public int CardId { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
}
