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

        public void SetName()
        {
            Console.WriteLine("Please enter player name:");
            this.name =  Console.ReadLine();
        }
        public string GetName()
        {
            return name;
        }


        
        
        

        //public void ChangeTotalDollars()
        //{
        //    totalDollars + //pull in price of supplies supplyName.GetPrice
        //}

        

    }
}
