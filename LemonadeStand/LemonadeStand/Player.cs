using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        string name;
        double totalDollars;
        int score;

        public Player(double totalDollars)
        {
            this.totalDollars = totalDollars;
            this.score = 0;
        }
        public void SetName()
        {
            Console.WriteLine("Please enter player name:");
            this.name =  Console.ReadLine();
        }
        public string GetName()
        {
            return name;
        }
        public int GetScore()
        {
            return score;
        }
        
        public void AddOneToScore()
        {
            score++;
        }
        public double GetTotalDollars()
        {
            return totalDollars;
        }
        public void BuySupply(Supply supply)
        {
            Console.WriteLine("Enter total ")
            supply.GetPrice
        }
        

        //public void ChangeTotalDollars()
        //{
        //    totalDollars + //pull in price of supplies supplyName.GetPrice
        //}

        

    }
}
