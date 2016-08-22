using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Bank
    {
        public decimal dollarTotal = 30;
        decimal dollarsEarned = 0;
        public bool playerHasMoney;

        public void SubtractFromDollarTotal(decimal dollarAmount)
        {
            dollarTotal = dollarTotal - dollarAmount;
        }
        public void AddToDollarTotal(decimal dollarAmount)
        {
            dollarTotal = dollarTotal + dollarAmount;
        }

        public decimal GetDollarTotal()
        {
            return dollarTotal;
        }
        public void DisplayFunds()
        {
            Console.WriteLine("\t\t\tTotal funds in cashbox: $" + GetDollarTotal() + "\n");
        }
        public decimal GetDollarsEarned()
        {
            return dollarsEarned;
        }
        public void AddOneCupEarned(decimal cupPrice)
        {
            dollarsEarned += cupPrice;
            dollarTotal += cupPrice;
        }

        public void SetPlayerHasMoney()
        {
            if (dollarTotal > 0)
            {
                playerHasMoney = true;
            }
        }
        public void GiveBankUpdate()
        {
            if (dollarTotal > 0)
            {
                Console.WriteLine("Congratulations you have ${0} in your bank.", dollarTotal);
                playerHasMoney = true;
            }
            else
            {
                Console.WriteLine("You have ${0} in your bank. UH OHHHHHH! You're in the red! \nGAME OVER", dollarTotal);
                playerHasMoney = false;
            }
        }
        public void ZeroOutDollarsEarned()
        {
            dollarsEarned = 0;
        }
    }
}
