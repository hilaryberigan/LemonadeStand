using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Menu
    {
        Inventory inventory;
        Bank bank;
        Day day;
        public Menu(Inventory inventory, Bank bank, Day day)
        {
            this.inventory = inventory;
            this.bank = bank;
            this.day = day;
        }
        public void DisplayMenu(string playerName)
        {
            int choice;
            do
            {
                Console.WriteLine("{0}'s Lemonade Stand\n", playerName);
                inventory.DisplayRecipe();
                inventory.DisplayPriceList();
                inventory.DisplayInventory();
                bank.DisplayFunds();               
             
                Console.WriteLine("\nInventory Options Menu\n");
                Console.WriteLine("1. Buy more lemons.");
                Console.WriteLine("2. Buy more sugar.");
                Console.WriteLine("3. Buy more ice.");
                Console.WriteLine("4. Buy more cups.");
                Console.WriteLine("5. I'm good. Move on.");
                Console.WriteLine("\nMake a choice from 1-5.");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        BuyMoreLemons();
                        break;
                    case 2:
                        BuyMoreSugar();
                        break;
                    case 3:
                        BuyMoreIce();
                        break;
                    case 4:
                        BuyMoreCups();
                        break;
                    default:
                        break;
                }
            } while (choice != 5);
            
            Console.Clear();
        }

        public void BuyMoreLemons()
        {
            foreach (Supply supply in inventory.supplyList)
            {
                if (supply.type == "lemons")
                {
                    supply.BuySupplies(bank);
                }
            }
            Console.WriteLine("Press {Enter} to add the new supplies to your inventory");
            Console.ReadLine();
        }
        public void BuyMoreSugar()
        {
            foreach (Supply supply in inventory.supplyList)
            {
                if (supply.type == "cups of sugar")
                {
                    supply.BuySupplies(bank);
                }
            }
            Console.WriteLine("Press {Enter} to add the new supplies to your inventory");
            Console.ReadLine();
        }
        public void BuyMoreIce()
        {
            foreach (Supply supply in inventory.supplyList)
            {
                if (supply.type == "ice cubes")
                {
                    supply.BuySupplies(bank);
                }
            }
            Console.WriteLine("Press {Enter} to add the new supplies to your inventory");
            Console.ReadLine();
        }
        public void BuyMoreCups()
        {
            foreach (Supply supply in inventory.supplyList)
            {
                if (supply.type == "cups")
                {
                    supply.BuySupplies(bank);
                }
            }
            Console.WriteLine("Press {Enter} to add the new supplies to your inventory");
            Console.ReadLine();
        }
    }
}
