using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandddd
{
    class Lemons : Supply
    {
        public Lemons()
        {
            type = "lemons";
            price = 0.25m;
            measureOfSupply = "lemons";
            numberOfSupplyPerPitcher = 6;
          
        }
        public override void GetPrice()
        {
            Console.WriteLine("\tprice per lemon:\t\t\t $" + price);
        }
        public override void GetTypeAndTotalNumber()
        {
            Console.WriteLine("\t" + type + " : \t\t" + totalNumberOfSupply);
        }
        public override void GetTypeAndNumberPerPitcher()
        {
            Console.WriteLine("\t" + type + " : \t\t{0}", numberOfSupplyPerPitcher);
        }
    }
}
