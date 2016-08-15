using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        string name;
        bool boughtGlass;
        int thirst;
        double willPay;

        public Customer(int thirst)
        {
            this.thirst = thirst;
        }
        public void BuyGlass()
        {
            boughtGlass = true;
        }
        //public bool BoughtGlass()
        //{
        //    Random random = new Random();
        //    if (random.Next(100) < thirst && cupPrice < willPay)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}
