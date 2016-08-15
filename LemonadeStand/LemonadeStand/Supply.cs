using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Supply
    {
        double price;
        double totalNumber;
        string type;
        public double cost;

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

        public double GetTotalNumber()
        {
            return this.totalNumber;
        }
        public double SetSupplyTotal()
        {
            Console.WriteLine("How many " + GetType() + " do you want to buy?");
            double numberOfSupplies = Convert.ToDouble(Console.ReadLine());
            this.totalNumber = this.totalNumber + numberOfSupplies;
            cost = totalNumber * price;
            return cost;

        }
    }
        }

    

