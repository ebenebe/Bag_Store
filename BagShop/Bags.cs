using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagShop
{
   public class Bags
    {
        public string[] bagList = { "Full Decorative", "Beaded", "Pirate Design", "Fringed", "Leather", "Plain" };
        public double[] bagPrice = { 50.0, 45.0, 40.0, 25.0, 80.0, 20.0 };
                       
       public string Name { get; set; }
        public string SelectedBag { get; set; }
       public double Price { get; set; }
        public double TotalAmount { get; set; }
        public string QuantitySelected { get; set; }

        public Bags()
        {
          
        
        } 
            
    }
}
