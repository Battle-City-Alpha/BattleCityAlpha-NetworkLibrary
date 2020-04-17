﻿using BCA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientGiveTitle : Packet
    {
        public string Target { get; set; }
        public int TitleID { get; set; }
    }
}
