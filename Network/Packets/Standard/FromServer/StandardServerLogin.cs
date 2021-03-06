﻿using BCA.Network.Packets.Enums;
using System;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerLogin : Packet
    {
        public bool Success { get; set; }
        public LoginFailReason Reason { get; set; }

        public string MaintenanceReason { get; set; }
        public int MaintenanceTimeEstimation { get; set; }

        public string SanctionReason { get; set; }
        public DateTime EndSanction { get; set; }
    }
}
