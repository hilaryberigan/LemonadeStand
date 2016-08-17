using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        Supply lemons = new Supply("lemons", 0.05);
        Supply sugar = new Supply("cups of sugar", 0.05);
        Supply ice = new Supply("bags of ice", 0.50);
        Supply cups = new Supply("sleeves of cups", 0.25);
        double totalDollars;
        double cost;
        double numberOfPitchers;
        public Inventory(double totalDollars)
        {
            this.totalDollars = totalDollars;
        }
        public void GetInventory()
        {
            Console.WriteLine("\t" + lemons.GetType() + " : \t" + lemons.GetTotalNumber());
            Console.WriteLine("\t" + sugar.GetType() + " : \t" + sugar.GetTotalNumber());
            Console.WriteLine("\t" + ice.GetType() + " : \t" + ice.GetTotalNumber());
            Console.WriteLine("\t" + cups.GetType() + " : \t" + cups.GetTotalNumber() + "\n");
            GetNumberOfPitchers();
        }
        public void GetPriceList()
        {
            Console.WriteLine("\nSupply Price List:\n");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("price per lemon:\t\t\t $" + lemons.GetPrice());
            Console.WriteLine("price per cup of sugar:\t\t\t $" + sugar.GetPrice());
            Console.WriteLine("price per bag of ice (25 cubes):\t $" + ice.GetPrice());
            Console.WriteLine("price per sleeve of cups (10 cups):\t $" + cups.GetPrice());
            Console.WriteLine("------------------------------------");
        }
        public void SetSupplyTotals()
        {
            SetLemonTotals();
            SetSugarTotals();
            SetIceTotals();
            SetCupsTotal();
        }
        public void SetLemonTotals()
        {
            cost = lemons.SetSupplyTotal();
            GetRemainingDollars();
        }
        public void SetSugarTotals()
        {
            cost = sugar.SetSupplyTotal();
            GetRemainingDollars();
        }
        public void SetIceTotals()
        {
            cost = ice.SetSupplyTotal();
            GetRemainingDollars();
        }
        public void SetCupsTotal()
        {
            cost = cups.SetSupplyTotal();
            GetRemainingDollars();
        }
        public void GetRemainingDollars()
        {
            totalDollars = totalDollars - cost;
            Console.WriteLine("\nRemaining Funds: $" + totalDollars + "\n");
        }

        public void GetNumberOfPitchers()
        {
            if (sugar.GetTotalNumber() > 3)
            {
                numberOfPitchers = Math.Floor(sugar.GetTotalNumber() / 4);
                Console.WriteLine("\n\tNumber of Possible Pitchers: " + numberOfPitchers + "\n");
            }
            else
            {
                Console.WriteLine("\nNumber of Pitchers: SOLD OUT\n");
            }
        }

        }

    }

