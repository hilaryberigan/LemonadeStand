using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Stand stand = new Stand(20);
        Day day = new Day();
        public void RunGameOpening()
        {
            Console.WriteLine("Welcome to Lemonade Stand!\n");
            GetGameRules();
            stand.SetName();
        }
        public void RunGame()
        {
            stand.SetUpStand();
            day.SetUpForDay();
            day.MakeCustomers();


            //GoToNextDay();
            
        }
        
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
