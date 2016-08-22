using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        string playerName;

        Bank bank = new Bank();
        Inventory inventory = new Inventory();
        decimal profit;

        public Player()
        {
            
        }
        public void DisplayDailyFactors(Day day)
        {
            Console.WriteLine("{0}'s Lemonade Stand\n", playerName);
            inventory.DisplayRecipe();
            inventory.DisplayInventory();
            day.DisplayWeatherForecast();
            bank.DisplayFunds();
        }
        
        public void MakeDailyChoices(Day day)
        {
            Menu menu = new Menu(inventory, bank, day);
   
            inventory.DisplayPriceList();
            inventory.AddToInventory(bank);
            Console.Clear();          
            menu.DisplayMenu(playerName);
            Console.Clear();
            DisplayDailyFactors(day);
            inventory.DisplayPossiblePitchers();
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
            GiveDailyResults(day);
            Console.Clear();
        }
        public void SetUpStandForNewDay()
        { 
            bank.ZeroOutDollarsEarned();
            inventory.MeltIce();         
            inventory.ClearPossiblePitchersList();
        }
        public void SetPlayerName()
        {
            Console.WriteLine("Please enter player name:");
            this.playerName = Console.ReadLine();
            Console.Clear();
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
        public void GiveDailyResults(Day day)
        {
            Console.WriteLine("Today you sold {0} glasses of lemonade!", day.GetNumberGlassesBought());
            Console.WriteLine("\nTotal $ earned: " + bank.GetDollarsEarned());
            Console.WriteLine("\n{0} out of a possible {1} customers bought a glass of lemonade.", day.GetNumberGlassesBought(), day.GetMaxCustomers());
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
            else
            {
                return true;
            }
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

