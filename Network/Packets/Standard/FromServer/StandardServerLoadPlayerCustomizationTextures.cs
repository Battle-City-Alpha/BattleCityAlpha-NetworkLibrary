using BCA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerLoadPlayerCustomizationTextures : Packet
    {
        public Customization Avatar { get; set; }
        public Customization Border { get; set; }
        public Customization Sleeve { get; set; }
        public int Pos { get; set; }
    }
}
