using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Supply
    {
        double price;
        int totalNumber;
        string type;

        public Supply(string type, double price)
        {
            this.type = type;
            this.price = price;
            totalNumber = 0;
        }

        public string GetType()
        {
            return this.type;
        }
        public double GetPrice()
        {
            return this.price;
        }

        public int GetTotalNumber()
        {
            return this.totalNumber;
        }
        
        //public void ChangeTotalNumber()
        //{
        //    totalNumber + //pull in from user input
        //}
    }
}
