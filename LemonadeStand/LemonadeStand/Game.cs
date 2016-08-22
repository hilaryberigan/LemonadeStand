using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        Player player = new Player();
        int maxDays = 7;
        List<Day> days = new List<Day>();
        bool gameOn = true;
        public Game()
        {
            DisplayGameRules();
            player.SetPlayerName();
        }
        public void RunGame()
        {
           
            {
                int dayCount = 1;
                for (int i = 0; i < maxDays; i++)
                {
                    if (gameOn)
                    {
                        Day day = new Day();
                        days.Add(day);

                        player.DisplayDailyFactors(day);
                        player.MakeDailyChoices(day);
                        player.SetUpStand(day);
                        player.RunStand(day);
                        dayCount++;
                        Console.WriteLine("Day " + dayCount + "\n");
                        player.SetUpStandForNewDay();
                        CheckIfGameOn();
                    }
                    else
                    {
                        break;
                    }
                }
                DisplayGameOver();            } 
        }

        public void DisplayGameOver()
        {
            if (player.DisplayProfit() > 0)
            {
                Console.WriteLine("Congratulations! You ended with a profit of ${0}!", player.DisplayProfit());
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n\n\nGAME OVER! You ended with a ${0} loss of funds!", player.DisplayProfit());
                Console.ReadLine();
            }
        }

        public void DisplayGameRules()
        {
            Console.WriteLine("Lemonade Stand\n");
            Console.WriteLine("\nYou're goal is to make as much money as you can in one week by selling lemonade at your lemonade stand. \nGame Instructions:\n");
            Console.WriteLine("\t1. Buy supplies (cups, lemons, sugar and ice cubes) based on weather conditions.");
            Console.WriteLine("\t2. Set your price per cup.");
            Console.WriteLine("\t3. Sell your lemonade at the stand.");
            Console.WriteLine("\t4. Try different prices depending on conditions.");
            Console.WriteLine("\nAt the end of each day, you will see how much money you made. With your new bank, buy supplies for the next day. Ice will melt each night, so you must buy new ice each day.");
            Console.WriteLine("\nAt the end of the week, you win if you have a made a profit.");
            Console.WriteLine("\n\n\nPress {Enter} when you're ready to play.");
            Console.ReadLine();
            Console.Clear();

        }
        public void CheckIfGameOn()
        {
            if (player.CheckIfPlayerHasMoney() == false)
            {
                gameOn = false;
            }
        }

    }
}
