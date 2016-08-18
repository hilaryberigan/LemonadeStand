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
        Weather weather;
        Random random = new Random();
        List<Customer> customers = new List<Customer>();

        int maxCustomers = 45;
        public decimal cupPrice;
        public int dayNumber = 0;
        public decimal dailyDollarsEarned;
        public int numberGlassesBought = 0;
   
        public Day()
        {
            weather = new Weather();
            SetWeatherForecast();
            SetMaxCustomers();
            SetActualWeather();
            dayNumber++;
        }
        public void RunDay(Stand stand)
        {
            SetUpForDay();
            RevealGlassesBought(stand);
            GetActualWeather();
            GiveFinalNumbers();
        }
        public int SetMaxCustomers()
        {
            int actualtemperature = weather.GetActualTemperature();
            maxCustomers = maxCustomers + ((actualtemperature - maxCustomers) * 2);
            return maxCustomers; //add something with skytype
        }    

        public void MakeCustomers()
        {
            for (int i = 0; i < maxCustomers; i ++)
            {
                Customer customer = new Customer(weather, cupPrice);
                customers.Add(customer);
                Thread.Sleep(15);
            }
        }

        public void RevealGlassesBought(Stand stand)
        {
            foreach (Customer customer in customers)
            {
                if (customer.wantsGlass == true && stand.numberOfGlassesToBeSold > 0)
                {
                    Console.WriteLine("Customer buys glass of lemonade.");
                    numberGlassesBought++;
                    stand.numberOfGlassesToBeSold--;
                }
                else if (customer.wantsGlass == false)
                {
                    Console.WriteLine("Customer walks by");
                }
                else if (customer.wantsGlass == true && stand.numberOfGlassesToBeSold == 0)
                {
                    Console.WriteLine("Oh no!! A customer wants to buy a glass but you are sold out!");
                }
            }
        }
        
        public decimal GetTotalEarned()
        {
            dailyDollarsEarned = (decimal)numberGlassesBought * cupPrice;
            return dailyDollarsEarned;
        }
        public void GiveFinalNumbers()
        {
            GetTotalEarned();
            Console.WriteLine("Today you sold {0} glasses of lemonade!", numberGlassesBought);
            Console.WriteLine("Total $ earned: " + dailyDollarsEarned);
            //addcurrentInventory
        }

        public void SetWeatherForecast()
        {
            weather.SetTemperatureForecast();
            weather.SetSkyTypeForecast();
        }
        public void GetWeatherForecast()
        {
            Console.WriteLine("\nToday's weather forecast: \n");
            Console.WriteLine("\t" + weather.GetSkyTypeForecast());
            Console.WriteLine("\t" + weather.GettemperatureForecast() + "° F\n");
        }
        public void SetActualWeather()
        {
            weather.SetActualTemperature();
            weather.SetActualSkyType();
        }
        public void GetActualWeather()
        {
            Console.WriteLine("Today's weather was: \n");
            Console.WriteLine("\t" + weather.GetActualSkyType());
            Console.WriteLine("\t" + weather.GetActualTemperature() + "° F\n");
        }

        public void SetUpForDay()
        {
            GetWeatherForecast();
            SetCupPrice();
            MakeCustomers();
        }
        public void SetCupPrice()
        {
            Console.WriteLine("How much would you like each glass of lemonade to cost?");
            cupPrice = Convert.ToDecimal(Console.ReadLine());
        }
        
    }

}
