using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class IceSupply : Supply
    {
        int numberCubesPerBag = 25;

        public IceSupply()
        {
            type = "ice cubes";
            price = .5m;
            measureOfSupply = "bags of ice";
            numberOfSupplyPerPitcher = 20;
        }

        public override void GetPrice()
        {
            Console.WriteLine("\tprice per bag of ice (" + numberCubesPerBag + type + "):\t $" + price);
        }
        public override void SetSupplyTotals()
        {
            Console.WriteLine("How many " + measureOfSupply + " do you want to buy?");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                numberOfSupplyBought = 0;
            }
            else
            {
                numberOfSupplyBought = Convert.ToInt32(input);
            }
            this.totalNumberOfSupply = this.totalNumberOfSupply + (numberOfSupplyBought * numberCubesPerBag);
        }
        public override void SetTotalCostOfSupply()
        {
            costOfSupply = numberOfSupplyBought * price;
        }
        public override void GetTypeAndTotalNumber()
        {
            Console.WriteLine("\t" + type + " : \t\t" + totalNumberOfSupply);
        }
        public override void GetTypeAndNumberPerPitcher()
        {
            Console.WriteLine("\t" + type + " : \t\t{0}", numberOfSupplyPerPitcher);
        }
        public override void ResetNumberOfSupplyBought()
        {
            this.totalNumberOfSupply = this.totalNumberOfSupply - (numberOfSupplyBought * numberCubesPerBag);
        }
    }
}