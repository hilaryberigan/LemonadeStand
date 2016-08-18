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
        public decimal bank;
        int maxPossiblePitchers;
        public int numberOfGlassesToBeSold;
        int numberOfActualPitchers = 0;
        List<Supply> supplyList = new List<Supply>();
       

        public Stand(decimal bank)
        {
            this.bank = bank;
            supplyList.Add(new Lemons());
            supplyList.Add(new Sugar());
            supplyList.Add(new Ice());
            supplyList.Add(new Cups());
        }
        public void SetPossibleGlassesToBeSold()
        {
            numberOfGlassesToBeSold = maxPossiblePitchers * 10;
        }
        public void GivePlayerInfo()
        {
            Console.Clear();
            GetTitle();
            Console.WriteLine("-----------------------------");
            MakeInventory();
            Console.WriteLine("\n");
            Getbank();
            Console.WriteLine("-----------------------------");
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
            foreach (Supply supply in supplyList)
            {
                supply.GetType();
            }
        }
        public void GetPriceList()
        {
            Console.WriteLine("\nSupply Price List:\n");
            Console.WriteLine("------------------------------------");
            foreach (Supply supply in supplyList)
            {
                supply.GetPrice();
            }
            Console.WriteLine("------------------------------------");
        }
        List<int> possiblePitchers = new List<int>();
        public void MakePossiblePitchersList()
        {
            int pitchersBySupply;
            foreach (Supply supply in supplyList)
            {
                pitchersBySupply = Convert.ToInt32(Math.Floor(supply.GetTotalNumber() / supply.numberPerPitcher));
                possiblePitchers.Add(pitchersBySupply);
            }
        }
        public void SetPossiblePitchers()
        {
            MakePossiblePitchersList();
            int firstOption = possiblePitchers[0];
            int minItem = 0;
            for (int i = 1; i < possiblePitchers.Count; ++i)
            {
                if (possiblePitchers[i] <= firstOption)
                {
                    firstOption = possiblePitchers[i];
                    minItem = i;
                    maxPossiblePitchers = possiblePitchers[minItem];
                }
                else
                {
                   firstOption = maxPossiblePitchers;
                }
            }
        }
        public void TellPlayerPossiblePitchers()
        {
            SetPossiblePitchers();
            SetPossibleGlassesToBeSold();
            Console.WriteLine("You are able to make {0} pitchers, which makes {1} glases of lemonade.", maxPossiblePitchers, numberOfGlassesToBeSold);
        }
        
        public void BuyAllSupplies()
        {
            GetPriceList();
            foreach (Supply supply in supplyList)
            {
                supply.BuySupplies();
                bank -= supply.costOfSupply;
                if (bank > 0)
                {
                    Console.WriteLine("Remaining Funds: " + bank);
                }
                else
                {
                    bank += supply.costOfSupply;
                    Console.WriteLine("You do not have enough remaining funds. Please try again:");
                    supply.BuySupplies();                
                } 
             }
        }
        public void SetUpStand()
        { 
            BuyAllSupplies();
            Console.WriteLine();
            TellPlayerPossiblePitchers();
        }
        public void SetNumberOfPitchersToMake()
        {
            Console.WriteLine("How many pitchers would you like to make for today?");
            numberOfActualPitchers = Convert.ToInt32(Console.ReadLine());
        }
        public bool CheckIfPitcherTotalIsCorrect()
        {
            return numberOfActualPitchers > maxPossiblePitchers;
        }
        public void MakeLemonade()
        {
            foreach (Supply supply in supplyList)
            {
                for (int i = 0; i <= numberOfActualPitchers; i++)
                {
                    supply.UseSupply();
                }
            }
        }
        public void FillPitchers()
        {
            SetNumberOfPitchersToMake();
                while (CheckIfPitcherTotalIsCorrect())
                {
                    Console.WriteLine("The amount of pitchers you want to make won't work. Please try again.");
                    SetNumberOfPitchersToMake();
                }
            MakeLemonade();       

        }
        
}



}
    

