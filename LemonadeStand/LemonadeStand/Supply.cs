﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
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
        public decimal GetCostOfSupply()
        {
            return costOfSupply;
        }
        public virtual void SetTotalCostOfSupply()
        {
            costOfSupply = numberOfSupplyBought * price;
        }
        //
        //User Interaction with supplies
        //
        public void BuySupplies(Bank bank)
        {
            SetSupplyTotals();
            SetTotalCostOfSupply();
            PayForSupplies(bank);
        }
        public void PayForSupplies(Bank bank)
        {
            decimal supplyCost = GetCostOfSupply();
            bank.SubtractFromDollarTotal(supplyCost);

            if (bank.GetDollarTotal() < 0)
                { 
                    bank.AddToDollarTotal(supplyCost);
                    Console.WriteLine("\t\t\tYou do not have enough remaining funds. Please try again:\n");
                    ResetNumberOfSupplyBought();
                    BuySupplies(bank);
                }

            bank.DisplayFunds();
        }
        public virtual void ResetNumberOfSupplyBought()
        {
            this.totalNumberOfSupply = this.totalNumberOfSupply - numberOfSupplyBought;        
        }
        public virtual void SetSupplyTotals()
        {
            Console.WriteLine("\nHow many " + GetMeasure() + " do you want to buy?");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                numberOfSupplyBought = 0;
            }
            else
            {
                numberOfSupplyBought = Convert.ToInt32(input); 
            }
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

