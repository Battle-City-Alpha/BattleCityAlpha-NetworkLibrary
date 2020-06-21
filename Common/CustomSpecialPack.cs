using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Common
{
    public class CustomSpecialPack
    {
        public int Id { get; set; }
        public string Infos { get; set; }
        public Customization[] Customs { get; set; }
        public int Price { get; set; }
        public DateTime EndTime { get; set; }

        public CustomSpecialPack(int id, int price, string infos, DateTime time)
        {
            Id = id;
            Price = price;
            Infos = infos;
            EndTime = time;
        }
    }
}
