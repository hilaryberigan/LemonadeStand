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
            price = 0.15m;
            measure = "lemons";
            numberPerPitcher = 5;
        }
        public override void GetPrice()
        {
            Console.WriteLine("price per lemon:\t\t\t $" + price);
        }


       
    }


}
