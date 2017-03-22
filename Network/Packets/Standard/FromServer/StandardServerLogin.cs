﻿using BCA.Network.Packets.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerLogin : Packet
    {
        public bool Success { get; set; }
        public LoginFailReason Reason { get; set; }
    }
}
