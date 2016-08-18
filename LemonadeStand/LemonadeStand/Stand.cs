using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Stand
    {
        string playerName;
        double bank;
        double costOfSupply;
        double numberOfPitchers;
        Lemons lemons = new Lemons();
        Sugar sugar = new Sugar();
        Ice ice = new Ice();
        Cups cups = new Cups();

        public Stand(double bank)
        {
            this.bank = bank;
        }
        public void GivePlayerInfo()
        {
            Console.Clear();
            GetTitle();
            Console.WriteLine("-----------------------------");
            MakeInventory();
            Getbank();
        }

        public void SetName()
        {
            Console.WriteLine("Please enter player name:");
            this.playerName = Console.ReadLine();
        }
        public void GetTitle()
        {
            Console.WriteLine("Welcome to " + GetName() + "'s Lemonade Stand!");
        }
        public string GetName()
        {
            return playerName;
        }
       
        public void Getbank()
        {
            Console.WriteLine("Total bank: \t $" + bank);
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
            BuyLemons();
            BuyIce();
            BuySugar();
            BuyCups();
        }
        public void BuyLemons()
        {
            costOfSupply = lemons.BuySupplies();
            GetRemainingBank();  
        }
        public void BuyIce()
        {
            costOfSupply = ice.BuySupplies();
            GetRemainingBank();
        }
        public void BuySugar()
        {
            costOfSupply = sugar.BuySupplies();
            GetRemainingBank();
        }
        public void BuyCups()
        {
            costOfSupply = cups.BuySupplies();
            GetRemainingBank();
        }
        public void GetRemainingBank()
        {
            this.bank -= costOfSupply;
            if (bank > 0)
            {
                Console.WriteLine("Remaining Funds: " + bank);
            }
            else
            {
                Console.WriteLine("You do not have enough remaining funds. Please try again:");
                ///need something here
            }

        }
        public void SetUpStand()
        {
            BuyAllSupplies();
        }
    }



}
    

