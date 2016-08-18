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
        protected int totalNumberOfSupply;
        protected string type;
        protected string measure;
        public decimal costOfSupply;
        protected int numberOfSupplyBought;
        public int numberPerPitcher;
        public decimal numberOfPossiblePitchers;

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
        public virtual void SetSupplyTotals()
        {
            Console.WriteLine("\nHow many " + GetMeasure() + " do you want to buy?");
            numberOfSupplyBought = Convert.ToInt32(Console.ReadLine());
            this.totalNumberOfSupply = this.totalNumberOfSupply + numberOfSupplyBought;
        }
        


        public virtual decimal GetTotalCostOfSupply()
        {
            costOfSupply = numberOfSupplyBought * price;
            return costOfSupply;
        }
        public void BuySupplies()
        {
            SetSupplyTotals();
            if (totalNumberOfSupply < numberPerPitcher)
            {
                Console.WriteLine("\nI'm sorry, that will not be enough to make even one pitcher. \nHow many " + GetMeasure() + " do you want to buy?");
                SetSupplyTotals();
            }
            else
            {
                GetTotalCostOfSupply();
            }
 
        }
       
        public void UseSupply()
        {
            totalNumberOfSupply -= numberPerPitcher;
        }

    }
        }

    

