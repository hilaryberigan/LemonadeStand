using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LemonadeStandddd
{
    class Player
    {
        string playerName;

        Bank bank = new Bank();
        Inventory inventory = new Inventory();
        decimal profit;

        public void SetPlayerName()
        {
            Console.WriteLine("Please enter player name:");
            this.playerName = Console.ReadLine();
            Console.Clear();
        }
        public void DisplayDailyFactors(Day day)
        {
            inventory.DisplayRecipe();
            inventory.DisplayPriceList();
            day.DisplayWeatherForecast();
            bank.DisplayFunds();
        }
        public void MakeDailyChoices(Day day)
        {
            inventory.AddToInventory(bank);
            Console.Clear();
            inventory.CreateInventoryList();
            day.DisplayWeatherForecast();
            inventory.DisplayPossiblePitchers();
            Console.WriteLine("\n");
            FillPitchers();
            day.SetCupPrice();
            Console.Clear();
        }
        public void RunStand(Day day)
        {
            day.MakeCustomers();
            day.RevealGlassesBought(inventory, bank);
            Console.WriteLine("\n");
            day.DisplayActualWeather();
            GiveFinalNumbers(day);
            bank.ZeroOutDollarsEarned();             
            inventory.MeltIce();
            Console.Clear();
            inventory.ClearPossiblePitchersList();
            inventory.CreateInventoryList();
        }

        public void FillPitchers()
        {
            inventory.SetPlayerRequestForPitchers();
            while (inventory.CheckIfPitcherTotalIsAboveMax())
            {
                Console.WriteLine("The amount of pitchers you want to make won't work. Please try again.");
                inventory.SetPlayerRequestForPitchers();
            }
            inventory.MakeLemonade();
        }
        public void GiveFinalNumbers(Day day)
        {
            Console.WriteLine("Today you sold {0} glasses of lemonade!", day.GetNumberGlassesBought());
            Console.WriteLine("Total $ earned: " + bank.GetDollarsEarned());
            Console.WriteLine("\n{ENTER}");
            Console.ReadLine();
        }
        public bool CheckIfPlayerHasMoney()
        {
            bank.SetPlayerHasMoney();
            if (!bank.playerHasMoney)
            {
                return false;
            }
            return true;
        }
        public void SetUpStand(Day day)
        {
            Console.WriteLine("{0}'s Lemonade Stand", playerName);
            Console.WriteLine("Lemonade: ${0} per cup\n", day.GetCupPrice());
            Console.WriteLine("------------------------------------\n");
        }
        public decimal DisplayProfit()
        {
            profit = bank.GetDollarTotal() - 30;
            return profit;
        }
    }
}
