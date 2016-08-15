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
        decimal totalDollars;
        int score;

        public Player(string name, decimal totalDollars)
        {
            this.name = name;
            this.totalDollars = totalDollars;
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
        public decimal GetTotalDollars()
        {
            return totalDollars;
        }

        public void ChangeTotalDollars()
        {
            totalDollars + //pull in price of supplies supplyName.GetPrice
        }
    }
}
