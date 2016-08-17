using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        Lemons lemons = new Lemons();
        Sugar sugar = new Sugar();
        Supply ice = new Ice();
        Supply cups = new Cups();
       
        double numberOfPitchers;
       
        public Inventory()
        {
             
        }
        public void MakeInventory()
        {
            lemons.GetType();
            sugar.GetType();
            ice.GetType();
            cups.GetType();
            GetNumberOfPitchers();
        }
        public void GetPriceList()
        {
            Console.WriteLine("\nSupply Price List:\n");
            Console.WriteLine("------------------------------------");
            lemons.GetPrice();
            sugar.GetPrice();
            ice.GetPrice();     
            cups.GetPrice();
            Console.WriteLine("------------------------------------");
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
        public void BuyAllSupplies()
        {
            GetPriceList();
            lemons.BuySupplies();
            sugar.BuySupplies();
            ice.BuySupplies();
            cups.BuySupplies();
        }
    }
        
        }

    

