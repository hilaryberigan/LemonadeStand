using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Stand
    {
        public decimal bank = 20;
        string playerName;
        int maxPossiblePitchers;
        public int numberOfGlassesToBeSold;
        int numberOfActualPitchers = 0;
        List<Supply> supplyList = new List<Supply>();
        List<int> possiblePitchers = new List<int>();


        public Stand()
        {
            supplyList.Add(new Lemons());
            supplyList.Add(new Sugar());
            supplyList.Add(new Ice());
            supplyList.Add(new Cups());
        }
        public void SetUpStand()
        {
            BuyAllSupplies();
            //more
        }
        //
        //player info//
        //
        public void GivePlayerInfo()
        {
            Console.Clear();
            GetTitle();
            Console.WriteLine("-----------------------------");
            MakeInventory();
            Console.WriteLine("\n");
            GetBank();
            Console.WriteLine("-----------------------------");
        }
        public void SetName()
        {
            Console.WriteLine("Please enter player name:");
            this.playerName = Console.ReadLine();
            Console.Clear();
        }
        public void GetTitle()
        {
            Console.WriteLine("Welcome to " + playerName + "'s Lemonade Stand!");
        }
        //
        //Inventory//-----------------------
        //
        public void MakeInventory()
        {
            foreach (Supply supply in supplyList)
            {
                supply.GetTypeAndTotalNumber();
            }
        }
       
        public void BuyAllSupplies()
        {
            CreatePriceList();
            foreach (Supply supply in supplyList)
            {
                supply.HaveUserBuySupplies();
                bank -= supply.costOfSupply;
                if (bank > 0)
                {
                    Console.WriteLine("\t\t\t\t\t\tRemaining Funds: " + bank + "\n");
                }
                else
                {
                    bank += supply.costOfSupply;
                    Console.WriteLine("\t\t\t\t\t\tYou do not have enough remaining funds. Please try again:\n");
                    supply.HaveUserBuySupplies();
                }
            }
        }
        //
        //Money Stuff//-------------------------
        //
        public void GetBank()
        {
            Console.WriteLine("Total bank: \t $" + bank);
        }
       
        public void CreatePriceList()
        {
            Console.WriteLine("\nSupply Price List:\n");
            Console.WriteLine("\t------------------------------------");
            foreach (Supply supply in supplyList)
            {
                supply.GetPrice();
            }
            Console.WriteLine("\t------------------------------------\n");
        }    
     
        //
        //Making Lemonade--------------------
        //
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
        public void MakeLemonade()
        {
            foreach (Supply supply in supplyList)
            {
                for (int i = 0; i < numberOfActualPitchers; i++)
                {
                    supply.UseOneMeasureOfSupply();
                }
            }
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
                    maxPossiblePitchers = firstOption;
                }
            }
        }
        public void TellPlayerPossiblePitchers()
        {
            SetPossiblePitchers();
            SetPossibleGlassesToBeSold();
            Console.WriteLine("You are able to make {0} pitchers, which makes {1} glasses of lemonade.", maxPossiblePitchers, numberOfGlassesToBeSold);
        }
        public void SetPossibleGlassesToBeSold()
        {
            numberOfGlassesToBeSold = maxPossiblePitchers * 10;
        }
 
        public void MakePossiblePitchersList()
        {
            int pitchersBySupply;
            foreach (Supply supply in supplyList)
            {
                pitchersBySupply = Convert.ToInt32(Math.Floor(supply.GetTotalNumber() / supply.numberPerPitcher));
                possiblePitchers.Add(pitchersBySupply);
            }
        }
        public void ShowRecipe()
        {
            Console.WriteLine("Lemonade Recipe per Pitcher:");
            Console.WriteLine("\t------------------------------------");
            foreach (Supply supply in supplyList)
            {
                Console.WriteLine("\t" + supply.type + " : \t\t{0}", supply.numberPerPitcher);
            }
            Console.WriteLine("\t------------------------------------\n");
        }
    }
}
    

