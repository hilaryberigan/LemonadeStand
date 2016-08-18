using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Ice : Supply
    {
        int numberCubesPerBag = 25;
     
        public Ice()
        {
            type = "ice cubes";
            price = .50m;
            measure = "bags of ice";
        }
        public override void GetPrice()
        {
            Console.WriteLine("price per bag of ice (25 cubes):\t $" + price);
        }
        public override void SetSupplyTotals()
        {
            Console.WriteLine("How many " + measure + " do you want to buy?");
            numberOfSupplyBought = Convert.ToDecimal(Console.ReadLine());
            this.totalNumberOfSupply = this.totalNumberOfSupply + (numberOfSupplyBought * numberCubesPerBag);
        }
        public override decimal GetTotalCostOfSupply()
        {
            costOfTotalSupply = numberOfSupplyBought * price;
            return costOfTotalSupply;
        }
    }
    }

