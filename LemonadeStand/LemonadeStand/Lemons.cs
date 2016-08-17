using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Lemons : Supply
    {
        public Lemons()
        {
            type = "lemons";
            price = 0.05;
            measure = "lemons";
        }
        public override void GetPrice()
        {
            Console.WriteLine("price per lemon:\t $" + price);
        }


       
    }


}
