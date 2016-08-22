using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class SugarSupply : Supply
    {
        public SugarSupply()
        {
            type = "cups of sugar";
            price = 0.25m;
            measureOfSupply = "cups of sugar";
            numberOfSupplyPerPitcher = 4;
        }
        public override void GetPrice()
        {
            Console.WriteLine("\tprice per cup of sugar:\t\t\t $" + price);
        }
        public override void GetTypeAndTotalNumber()
        {
            Console.WriteLine("\t" + type + " : \t" + totalNumberOfSupply);
        }
        public override void GetTypeAndNumberPerPitcher()
        {
            Console.WriteLine("\t" + type + " : \t{0}", numberOfSupplyPerPitcher);
        }
    }

}
