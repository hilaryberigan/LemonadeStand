using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class CupSupply : Supply
    {
        int numberCupsPerSleeve = 25;
        public CupSupply()
        {
            type = "cups";
            price = .5m;
            measureOfSupply = "sleeves of cups";
            numberOfSupplyPerPitcher = 7;
        }
        public override void GetPrice()
        {
            Console.WriteLine("\tprice per sleeve of cups (" + numberCupsPerSleeve + type + "):\t $" + price);
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
            this.totalNumberOfSupply = this.totalNumberOfSupply + (numberOfSupplyBought * numberCupsPerSleeve);
        }
        public override void SetTotalCostOfSupply()
        {
            costOfSupply = numberOfSupplyBought * price;
        }
        public override void GetTypeAndTotalNumber()
        {
            Console.WriteLine("\t" + type + " : \t\t\t" + totalNumberOfSupply);
        }
        public override void GetTypeAndNumberPerPitcher()
        {
            Console.WriteLine("\t" + type + " : \t\t\t{0}", numberOfSupplyPerPitcher);
        }
        public override void ResetNumberOfSupplyBought()
        {
            this.totalNumberOfSupply = this.totalNumberOfSupply - (numberOfSupplyBought * numberCupsPerSleeve);
        }
    }
}