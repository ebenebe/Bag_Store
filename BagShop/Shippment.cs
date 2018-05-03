using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagShop
{
   public class Shippment
    {
        public int OverNight { get; set; }
        public int _3Day { get; set; }
        public int Standard { get; set; }
        public double ShippmentFee { get; set; }

        public Shippment()
        {
            OverNight = 10;
            _3Day = 7;
            Standard = 5;

        }
        
    }
}
