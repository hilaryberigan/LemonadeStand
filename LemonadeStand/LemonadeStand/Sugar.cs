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
            type = "sugar";
            price = 0.05;
            measure = "cups of sugar";
        }
        public override void GetPrice()
        {
            Console.WriteLine("price per cup of sugar:\t $" + price);
        }
    }
}
