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
        
        int maxCustomers = 45;
        int dayNumber = 1;
        public decimal cupPrice;
   
        public Day()
        {
            weather = new Weather();
            SetWeatherForecast();
            SetMaxCustomers();
            SetActualWeather();
        }
        public int SetMaxCustomers()
        {
            int actualtemperature = weather.GetActualTemperature();
            maxCustomers = maxCustomers + ((actualtemperature - maxCustomers)*2);
            return maxCustomers; //add something with skytype
        }

        List<Customer> customers = new List<Customer>();

        public void MakeCustomers()
        {
            for (int i = 0; i < maxCustomers; i ++)
            {
                Customer customer = new Customer(weather, cupPrice);
                customers.Add(customer);
                Thread.Sleep(100);
            }
        }

        public void RunDay()
        {
            
           
               
            }
            

        public int GetMaxCustomers()
        {
            return maxCustomers;
        }
        public void SetWeatherForecast()
        {
            weather.SetTemperatureForecast();
            weather.SetSkyTypeForecast();
        }
        public void GetWeatherForecast()
        {
            Console.WriteLine("\nToday's weather forecast: ");
            Console.WriteLine("\t" + weather.GetSkyTypeForecast());
            Console.WriteLine("\t" + weather.GettemperatureForecast() + " degrees F\n");
        }
        public void SetActualWeather()
        {
            weather.SetActualTemperature();
            weather.SetActualSkyType();
        }
        public void GetActualWeather()
        {
            Console.WriteLine("Today's weather was:");
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
        public void SetUpForDay()
        {
            SetCupPrice();
            //MakeLemonade (see how many of each supply and totalout pitchers)
        }
        public void SetCupPrice()
        {
            Console.WriteLine("How much would you like each glass of lemonade to cost?");
            cupPrice = Convert.ToDecimal(Console.ReadLine());
        }

    }

}
