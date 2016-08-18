using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Supply
    {
        protected decimal price;
        protected decimal totalNumberOfSupply;
        protected string type;
        protected string measure;
        public decimal costOfTotalSupply;
        protected decimal numberOfSupplyBought;

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

        public decimal GetTotalNumber()
        {
            return this.totalNumberOfSupply;
        }
        public virtual void SetSupplyTotals()
        {
            Console.WriteLine("\nHow many " + GetMeasure() + " do you want to buy?");
            numberOfSupplyBought = Convert.ToDecimal(Console.ReadLine());
            this.totalNumberOfSupply = this.totalNumberOfSupply + numberOfSupplyBought;
        }
        public virtual decimal GetTotalCostOfSupply()
        {
            costOfTotalSupply = numberOfSupplyBought * price;
            return costOfTotalSupply;
        }
        public decimal BuySupplies()
        {
            SetSupplyTotals();
            costOfTotalSupply = GetTotalCostOfSupply();
            return costOfTotalSupply;
        }
        

    }
        }

    

