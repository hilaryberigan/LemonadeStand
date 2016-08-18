using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Sugar : Supply
    {
        public Sugar()
        {
            type = "cups of sugar";
            price = 0.25m;
            measure = "cups of sugar";
            numberPerPitcher = 4;
        }
        public override void GetPrice()
        {
            Console.WriteLine("price per cup of sugar:\t\t $" + price);
        }
    }
}
