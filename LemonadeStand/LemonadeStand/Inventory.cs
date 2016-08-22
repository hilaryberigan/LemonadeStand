using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
       public List<Supply> supplyList = new List<Supply>();
        List<int> possiblePitchers = new List<int>();

        public int maxPossiblePitchers;
        public int numberOfPitchersRequested;
        public int numberOfGlassesToBeSold;

        public Inventory()
        {
            supplyList.Add(new LemonBasket());
            supplyList.Add(new SugarSupply());
            supplyList.Add(new IceSupply());
            supplyList.Add(new CupSupply());
        }

        public void DisplayInventory()
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
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Buy supplies for today's inventory...\n");
            foreach (Supply supply in supplyList)
            {
                supply.BuySupplies(bank);
            }

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
        public void SetPlayerRequestForPitchers()
        {
            Console.WriteLine("How many pitchers would you like to make for today?");
            numberOfPitchersRequested = Convert.ToInt32(Console.ReadLine());
            SetRequestedGlassesToBeSold();
        }
        public int GetNumberOfPitchersRequested()
        {
            return numberOfPitchersRequested;
        }
        public bool CheckIfPitcherTotalIsAboveMax()
        {
            return numberOfPitchersRequested > maxPossiblePitchers;
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
        public void ClearPossiblePitchersList()
        {
            foreach (int i in possiblePitchers.ToList()) //what does this mean?
            {
                possiblePitchers.Remove(i);
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
        public void SetMaxPossibleGlassesToBeSold()
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
            SetMaxPossibleGlassesToBeSold();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Choose how many pitchers to make...\n");
            Console.WriteLine("You are able to make {0} pitchers, which makes {1} glasses of lemonade.", maxPossiblePitchers, numberOfGlassesToBeSold);
        }
        
        public void MeltIce()
        {
            foreach (Supply supply in supplyList)
            {
                if (supply.GetType() == "ice cubes")
                {
                    supply.ZeroOutSupplyTotal();
                }
            }
        }


    }

}


