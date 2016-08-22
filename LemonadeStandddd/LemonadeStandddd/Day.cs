using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LemonadeStandddd
{

    public class Day
    {
        int dayNumber = 0;
        public Weather weather;
        int maxCustomersInDay = 45;
        decimal cupPriceForDay = 0;
        int numberGlassesBoughtInDay = 0;
        List<Customer> customers = new List<Customer>();


        public Day()
        {
            weather = new Weather();
            weather.SetWeatherForecast();
            weather.SetActualWeather();
            SetMaxCustomers();
            dayNumber++;
        }
       
        public void DisplayWeatherForecast()
        {
            Console.WriteLine("Today's weather forecast: \n");
            Console.WriteLine("\t" + weather.GetSkyTypeForecast());
            Console.WriteLine("\t" + weather.GettemperatureForecast() + "° F\n");
        }
        public void GetActualWeather()
        {
            weather.GetActualSkyType();
            weather.GetActualTemperature();
            Console.WriteLine("\n");
        }
        public void DisplayActualWeather()
        {
            Console.WriteLine("Today's weather was: \n");
            Console.WriteLine("\t" + weather.GetActualSkyType());
            Console.WriteLine("\t" + weather.GetActualTemperature() + "° F\n");
        }
        public int SetMaxCustomers()
        {
            int actualtemperature = weather.GetActualTemperature();
            maxCustomersInDay = maxCustomersInDay + ((actualtemperature - maxCustomersInDay) * 2);
            return maxCustomersInDay; //add something with skytype
        }
        public void SetCupPrice()
        {
            Console.WriteLine("How much would you like each glass of lemonade to cost?");
            cupPriceForDay = Convert.ToDecimal(Console.ReadLine());
        }
        public int GetMaxCustomers()
        {
            return maxCustomersInDay;
        }
        public decimal GetCupPrice()
        {
            return cupPriceForDay;
        }
        public void MakeCustomers()
        {
            for (int i = 0; i < maxCustomersInDay; i++)
            {
                Customer customer = new Customer(weather, cupPriceForDay);
                customers.Add(customer);
                Thread.Sleep(15);
            }
        }
        public void RevealGlassesBought(Inventory inventory, Bank bank)
        {
            foreach (Customer customer in customers)
            {
                if (customer.wantsGlass == true && inventory.numberOfGlassesToBeSold > 0)
                {
                    Console.WriteLine("Customer buys glass of lemonade.");
                    numberGlassesBoughtInDay++;
                    inventory.numberOfGlassesToBeSold--;
                    bank.AddOneCupEarned(cupPriceForDay);
                    
                }
                else if (customer.wantsGlass == false)
                {
                    Console.WriteLine("Customer walks by");
                }
                else if (customer.wantsGlass == true && inventory.numberOfGlassesToBeSold == 0)
                {
                    Console.WriteLine("Oh no!! A customer wants to buy a glass but you are sold out!");
                }
            }
        }
        public int GetNumberGlassesBought()
        {
            return numberGlassesBoughtInDay;
        }
        
    }
}

