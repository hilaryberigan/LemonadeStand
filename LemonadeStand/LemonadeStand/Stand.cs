using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Stand
    {
        string playerName;
        double bank;
        public decimal cupPrice;

        Inventory inventory = new Inventory();

        public Stand(double bank)
        {
            this.bank = bank;
        }

        public void GivePlayerInfo()
        {
            Console.Clear();
            GetTitle();
            Console.WriteLine("-----------------------------");
            GetInventory();
            Getbank();
        }

        public void SetName()
        {
            Console.WriteLine("Please enter player name:");
            this.playerName = Console.ReadLine();
        }
        public void GetTitle()
        {
            Console.WriteLine("Welcome to " + GetName() + "'s Lemonade Stand!");
        }
        public string GetName()
        {
            return playerName;
        }
        public void Getbank()
        {
            Console.WriteLine("Total bank: \t $");
        }
        //public void DeductSupplyCostFromBank()
        //{
        //    bank = bank - costOfTotalSuppy;
        //}
        public void SetUpStand()
        {
            inventory.BuyAllSupplies();
            SetCupPrice();
        }

        public void GetInventory()
        {
            inventory.MakeInventory();
        }
    }
    }

