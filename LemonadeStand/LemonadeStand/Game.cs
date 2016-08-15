using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Player player = new Player(30.00);
        Weather weather = new Weather();
        Inventory inventory = new Inventory();

        public void RunGameOpening()
        {
            Console.WriteLine("Welcome to Lemonade Stand!\n");
            player.SetName(); //maybe at end
            GetGameRules();
            inventory.GetPriceList();
        }
        public void RunGame()
        {
            weather.GetWeather();

        }
        public void GetGameRules()
        {
            Console.WriteLine("\nYou're goal is to make as much money as you can in one week by selling lemonade at your lemonade stand. \nGame Instructions:\n");
            Console.WriteLine("1. Buy supplies (cups, lemons, sugar and ice cubes), then set your recipe based on weather and conditions.");
            Console.WriteLine("2. Set your price per cup.");
            Console.WriteLine("3. Sell your lemonade at the stand.");
            Console.WriteLine("4. Try different recipes and prices depending on conditions.");
            Console.WriteLine("\nAt the end of the game, you will see how much money you made.");
            Console.WriteLine("\nPress Enter when you're ready to play.");
            Console.ReadLine();

        }



        
    }
}
