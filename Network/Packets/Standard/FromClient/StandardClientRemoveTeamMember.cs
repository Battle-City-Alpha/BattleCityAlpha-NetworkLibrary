﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientRemoveTeamMember : Packet
    {
        public int TargetID { get; set; }
    }
}