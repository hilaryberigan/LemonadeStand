using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Supply
    {
        decimal price;
        int totalNumber;
        string type;

        public Supply(string type, decimal price)
        {
            this.type = type;
            this.price = price;
            totalNumber = 0;
        }

        public string GetType()
        {
            return this.type;
        }
        public 

    }
}
