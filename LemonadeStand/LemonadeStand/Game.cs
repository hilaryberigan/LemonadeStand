using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Player player = new Player();
        Inventory inventory = new Inventory(30);
        Day day = new Day();

        public Game()
        {

        }
        public void RunGameOpening()
        {
            Console.WriteLine("Welcome to Lemonade Stand!\n");
            GetGameRules();
            inventory.GetPriceList();
        }
        public void RunGame()
        {
            day.GetWeatherForecast();
            Console.WriteLine("\n");
            inventory.SetSupplyTotals();
            Console.WriteLine("\nOkay, let's move on.\n");
            inventory.GetInventory();

            day.GoToNextDay();

            player.SetName();

        }

        //public void BuySupplies()
        //{
        //    inventory.SetSupplyTotals();

        //}
        
        public void GetGameRules()
        {
            Console.WriteLine("\nYou're goal is to make as much money as you can in one week by selling lemonade at your lemonade stand. \nGame Instructions:\n");
            Console.WriteLine("\t1. Buy supplies (cups, lemons, sugar and ice cubes), then set your recipe based on weather and conditions.");
            Console.WriteLine("\t2. Set your price per cup.");
            Console.WriteLine("\t3. Sell your lemonade at the stand.");
            Console.WriteLine("\t4. Try different recipes and prices depending on conditions.");
            Console.WriteLine("\nAt the end of the game, you will see how much money you made.");
            Console.WriteLine("\nPress {Enter} when you're ready to play."); //this should disappear when you hit enter
            Console.ReadLine();
            Console.Clear();

        }



        
    }
}
