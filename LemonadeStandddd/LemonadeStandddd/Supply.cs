using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandddd
{
    public class Supply
    {
        protected decimal price;
        protected int totalNumberOfSupply = 0;
        public string type;
        protected string measureOfSupply;
        protected decimal costOfSupply;
        protected int numberOfSupplyBought = 0;
        public int numberOfSupplyPerPitcher;


        public Supply()
        {
            totalNumberOfSupply = 0;
        }
        //'Get' Functions

        public string GetType()
        {
            return type;
        }
        public string GetMeasure()
        {
            return this.measureOfSupply;
        }
        public virtual void GetTypeAndTotalNumber()
        {
            Console.WriteLine("\t" + type + " : \t\t" + totalNumberOfSupply);
        }
        public virtual void GetPrice()
        {
            Console.WriteLine("The price is: " + price);
        }
        public decimal GetTotalNumber()
        {
            return this.totalNumberOfSupply;
        }
        public virtual void SetTotalCostOfSupply()
        {
            costOfSupply = numberOfSupplyBought * price;
        }
        //
        //User Interaction with supplies
        //
        public void BuySupplies()
        {
            
            SetSupplyTotals();
            if (totalNumberOfSupply < numberOfSupplyPerPitcher)
            {
                Console.WriteLine("\nI'm sorry, that will not be enough to make even one pitcher. \nHow many " + GetMeasure() + " do you want to buy?");
                SetSupplyTotals();
                SetTotalCostOfSupply();
            }
            else
            {
                SetTotalCostOfSupply();
            }
        }
        public decimal GetCostOfSupply()
        {
            return costOfSupply;
        }
        public virtual void SetSupplyTotals()
        {
            Console.WriteLine("\nHow many " + GetMeasure() + " do you want to buy?");
            numberOfSupplyBought = Convert.ToInt32(Console.ReadLine());
            this.totalNumberOfSupply = this.totalNumberOfSupply + numberOfSupplyBought;
        }
        public void UseOneMeasureOfSupply()
        {
            totalNumberOfSupply = totalNumberOfSupply - numberOfSupplyPerPitcher;
        }
        public void ZeroOutSupplyTotal()
        {
            totalNumberOfSupply = 0;
        }
        public virtual void GetTypeAndNumberPerPitcher()
        {
            Console.WriteLine("\t" + type + " : \t\t{0}", numberOfSupplyPerPitcher);
        }
    }
}

