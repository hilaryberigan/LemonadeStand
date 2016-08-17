using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        int dayNumber;
        Weather weather = new Weather();
        Random random = new Random();
        Inventory inventory = new Inventory(30);

        int maxCustomers;
        public decimal cupPrice;

        public Day()
        {
            dayNumber = 1;
            maxCustomers = 45;
         /*   SetMaxCustomers(); *///will this work with it happening before actual temp?
        }
        public int SetMaxCustomers()
        {
            int actualtemperature = weather.GetActualTemperature();
            maxCustomers = maxCustomers + (actualtemperature - maxCustomers);
            return maxCustomers; 
        }
        public void SetUpDay()
        {
            GetWeatherForecast();
            inventory.GetPriceList();
            inventory.SetSupplyTotals();
            inventory.GetInventory();
            SetCupPrice();
            Console.WriteLine("\nOkay, let's move on.\n{Enter}");
            Console.ReadLine();
            Console.Clear();
        }
        public void RunDay()
        {
            maxCustomers = SetMaxCustomers();
            int customerNumber = 1;
            while (customerNumber > 0 && customerNumber < (maxCustomers + 1))
            {
                Customer customer = new Customer(customerNumber);
                Thread.Sleep(100);
                customer.GetPreferences(cupPrice, weather.GetActualTemperature(), weather.GetActualSkyType());
                customerNumber++;
            }
            
        }
        public int GetMaxCustomers()
        {
            return maxCustomers;
        }
    public void GetWeatherForecast()
        {
            Console.WriteLine("\nToday's weather forecast: ");
            weather.Settemperature();
            weather.SetSkyType();
            Console.WriteLine("\t" + weather.GetSkyType());
            Console.WriteLine("\t" + weather.Gettemperature() + " degrees F\n");
        }
        public void GetActualWeather()
        {
            Console.WriteLine("Today's weather was:");
            weather.SetActualTemperature();
            weather.SetActualSkyType();
            Console.WriteLine("\t" + weather.GetActualSkyType());
            Console.WriteLine("\t" + weather.GetActualTemperature() + " degrees F\n");
        }

        public int GetDayNumber()
        {
            return dayNumber;
        }
        public void GoToNextDay()
        {
            dayNumber++;
        }
        public void SetCupPrice()
        {
            Console.WriteLine("How much will one cup cost?");
            cupPrice = Convert.ToDecimal(Console.ReadLine());
        }
    }

}
