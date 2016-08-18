using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Supply
    {
        protected double price;
        protected double totalNumberOfSupply;
        protected string type;
        protected string measure;
        public double costOfTotalSupply;
        protected double numberOfSupplyBought;

        public Supply()
        {
            totalNumberOfSupply = 0;
        }

        public string GetMeasure()
        {
            return this.measure;
        }
        public void GetType()
        {
            Console.WriteLine("\t" + type + " : \t" + totalNumberOfSupply);
        }
        public virtual void GetPrice()
        {
            Console.WriteLine("The price is: " + price);
        }

        public double GetTotalNumber()
        {
            return this.totalNumberOfSupply;
        }
        public virtual void SetSupplyTotals()
        {
            Console.WriteLine("\nHow many " + GetMeasure() + " do you want to buy?");
            numberOfSupplyBought = Convert.ToDouble(Console.ReadLine());
            this.totalNumberOfSupply = this.totalNumberOfSupply + numberOfSupplyBought;
        }
        public virtual double GetTotalCostOfSupply()
        {
            costOfTotalSupply = numberOfSupplyBought * price;
            return costOfTotalSupply;
        }
        public double BuySupplies()
        {
            SetSupplyTotals();
            costOfTotalSupply = GetTotalCostOfSupply();
            return costOfTotalSupply;
        }
        

    }
        }

    

