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
        Supply ice = new Supply("ice cubes", 0.50);
        Supply cups = new Supply("cups", 0.25)
        //should this be in game or program?

        public void GetInventory()
        {
            Console.WriteLine(lemons.GetType() + " : " + lemons.GetTotalNumber());
            Console.WriteLine(sugar.GetType() + " : " + sugar.GetTotalNumber());
            Console.WriteLine(ice.GetType() + " : " + ice.GetTotalNumber());
        }
        public void GetPriceList()
        {
            Console.WriteLine("\nSupply Price List:\n");
            Console.WriteLine("price per lemon: $" + lemons.GetPrice());
            Console.WriteLine("price per cup of sugar: $" + sugar.GetPrice());
            Console.WriteLine("price per bag of ice (25 cubes) : $" + ice.GetPrice());
            Console.WriteLine("price per sleeve of cups (10 cups) : $" + ice.GetPrice());
        }
    }
}
