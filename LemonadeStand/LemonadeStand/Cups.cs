using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Cups : Sugar
    {
        int numberCupsPerSleeve = 10;
        public Cups()
        {
            type = "cups";
            price = .50m;
            measure = "sleeve of cups";

        }
        public override void GetPrice()
        {
            Console.WriteLine("price per sleeve of cups (10 cups):\t $" + price);
        }
        public override void SetSupplyTotals()
        {
            Console.WriteLine("How many " + measure + " do you want to buy?");
            numberOfSupplyBought = Convert.ToDecimal(Console.ReadLine());
            this.totalNumberOfSupply = this.totalNumberOfSupply + (numberOfSupplyBought * numberCupsPerSleeve);
        }
        public override decimal GetTotalCostOfSupply()
        { 
            costOfTotalSupply = numberOfSupplyBought * price;
            return costOfTotalSupply;
        }
    }
}
