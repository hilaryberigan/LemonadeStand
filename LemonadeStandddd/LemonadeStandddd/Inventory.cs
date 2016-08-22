using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandddd
{
    public class Inventory
    {
        List<Supply> supplyList = new List<Supply>();
        List<int> possiblePitchers = new List<int>();

        public int maxPossiblePitchers;
        public int numberOfPitchersRequested;
        public int numberOfGlassesToBeSold;

        public Inventory()
        {
            supplyList.Add(new Lemons());
            supplyList.Add(new Sugar());
            supplyList.Add(new Ice());
            supplyList.Add(new Cups());
        }

        public void CreateInventoryList()
        {
            Console.WriteLine("\nYour Current Inventory\n");
            Console.WriteLine("\t------------------------------------");
            foreach (Supply supply in supplyList)
            {
                supply.GetTypeAndTotalNumber();
            }
            Console.WriteLine("\t------------------------------------\n");
        }
        public void AddToInventory(Bank bank)
        {
            Console.WriteLine("------------------------------------\n");
            Console.WriteLine("Buy supplies for today's inventory\n");
            foreach (Supply supply in supplyList)
            {
                supply.BuySupplies();
                decimal supplyCost = supply.GetCostOfSupply();
                bank.SubtractFromDollarTotal(supplyCost);
                if (bank.GetDollarTotal() >= 0)
                {
                    bank.DisplayFunds();
                }
                else
                {
                    bank.AddToDollarTotal(supplyCost);
                    Console.WriteLine("\t\t\tYou do not have enough remaining funds. Please try again:\n");
                    supply.BuySupplies();
                    bank.DisplayFunds();
                }
            }
            
        }
        public void DisplayPriceList()
        {
            Console.WriteLine("\nSupply Price List:\n");
            Console.WriteLine("\t------------------------------------");
            foreach (Supply supply in supplyList)
            {
                supply.GetPrice();
            }
            Console.WriteLine("\t------------------------------------\n");
        }
    
        public void MakeLemonade()
        {
        foreach (Supply supply in supplyList)
        {
            for (int i = 0; i < GetNumberOfPitchersRequested(); i++)
            {
                supply.UseOneMeasureOfSupply();
            }
        }
        }
        public int GetNumberOfPitchersRequested()
        {
            return numberOfPitchersRequested;
        }
        public void SetPlayerRequestForPitchers()
        {
            Console.WriteLine("How many pitchers would you like to make for today?");
            numberOfPitchersRequested = Convert.ToInt32(Console.ReadLine());
            SetRequestedGlassesToBeSold();
        }
        public bool CheckIfPitcherTotalIsAboveMax()
        {
            return numberOfPitchersRequested > maxPossiblePitchers;
        }
        public void ClearPossiblePitchersList()
        {
           foreach(int i in possiblePitchers.ToList()) //what does this mean?
            {
                possiblePitchers.Remove(i);
            }
        }
        public void MakePossiblePitchersList()
        {
            int pitchersBySupply;
            foreach (Supply supply in supplyList)
            {
                pitchersBySupply = Convert.ToInt32(Math.Floor(supply.GetTotalNumber() / supply.numberOfSupplyPerPitcher));
                possiblePitchers.Add(pitchersBySupply);
            }
        }
        public void SetMaxPossiblePitchers()
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
        public void SetPossibleGlassesToBeSold()
        {
            numberOfGlassesToBeSold = maxPossiblePitchers * 10;
        }
        public void SetRequestedGlassesToBeSold()
        {
            numberOfGlassesToBeSold = numberOfPitchersRequested * 10;
        }
        public void DisplayPossiblePitchers()
        {
            SetMaxPossiblePitchers();
            SetPossibleGlassesToBeSold();
            Console.WriteLine("You are able to make {0} pitchers, which makes {1} glasses of lemonade.", maxPossiblePitchers, numberOfGlassesToBeSold);
        }
        public void DisplayRecipe()
        {
            Console.WriteLine("Lemonade Recipe per Pitcher:\n");
            Console.WriteLine("\t------------------------------------");
            foreach (Supply supply in supplyList)
            {
                supply.GetTypeAndNumberPerPitcher();
            }
            Console.WriteLine("\t------------------------------------");
        }
       public void MeltIce()
        {
            foreach(Supply supply in supplyList)
            {
                if (supply.GetType() == "ice cubes")
                {
                    supply.ZeroOutSupplyTotal();
                }
            }
        }


    }

    }

