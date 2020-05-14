using BCA.Common;
using BCA.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerBoosterCollection : Packet
    {
        public string PurchaseTag { get; set; }
        public List<int> Id { get; set; }
        public List<int> Quantity { get; set; }
        public List<CardRarity> Rarity { get; set; }
    }
}
