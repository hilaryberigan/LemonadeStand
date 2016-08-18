﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Stand stand = new Stand(20);
        int maxDays = 2;
        public void RunGameOpening()
        {
            Console.WriteLine("Welcome to Lemonade Stand!\n");
            GetGameRules();
            stand.SetName();
        }
        List<Day> days = new List<Day>();
        public void RunGame()
        {
            for (int i = 0; i < maxDays; i++)
            { 
                Day day = new Day();
                days.Add(day);
                day.GetWeatherForecast();
                stand.SetUpStand();
                stand.GivePlayerInfo();
                day.RunDay(stand);
                stand.bank += day.dailyDollarsEarned;
                GiveBankUpdate();
                Console.WriteLine("\n\n\n{Enter}");
                Console.ReadLine();        
            }       
        }
        public void DeterminePlayerStatus()
        {
            Console.Clear();
            if (stand.bank > 0)
            {
                Console.WriteLine("\n\n\nCONGRATULATIONS!!!!\n\n\nYou win with a profit of ${0}.", stand.bank);
            }
            else
            {
                Console.WriteLine("\n\n\nGAME OVER! You ended with a ${0} loss of funds!", stand.bank);
            }
        }
        
        //public void GetTotalGlasses
        //public void RunGameEnding();
        
        
        public void GiveBankUpdate()
        {
            if (stand.bank > 0)
            {
                Console.WriteLine("Congratulations you are still have ${0} in your bank.", stand.bank);
            }
            else
            {
                Console.WriteLine("You have ${0} in your bank. UH OHHHHHH! You're in the red! \nGAME OVER", stand.bank);

            }
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
