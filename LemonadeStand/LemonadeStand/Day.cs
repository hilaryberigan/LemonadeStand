﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
       
        public Weather weather;
        int maxPossibleCustomers = 45;
        decimal cupPriceForDay = 0;
        int numberGlassesBoughtInDay = 0;
        List<Customer> customers = new List<Customer>();


        public Day()
        {
            weather = new Weather();
            weather.SetWeatherForecast();
            weather.SetActualWeather();
            SetMaxCustomers();
        }
        
        public void DisplayWeatherForecast()
        {
            Console.WriteLine("\nToday's weather forecast: \n");
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
            if (weather.GetActualSkyType() == "rainy")
            {
                maxPossibleCustomers -= 15;
            }
            maxPossibleCustomers = maxPossibleCustomers + ((actualtemperature - maxPossibleCustomers) * 2);
            return maxPossibleCustomers; 
        }
        public void SetCupPrice()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Choose the price per glass...\n");
            Console.WriteLine("How much would you like each glass of lemonade to cost? Choose any $ amount.");
            cupPriceForDay = Convert.ToDecimal(Console.ReadLine());
        }
        public int GetMaxCustomers()
        {
            return maxPossibleCustomers;
        }
        public decimal GetCupPrice()
        {
            return cupPriceForDay;
        }
        public void MakeCustomers()
        {
            for (int i = 0; i < maxPossibleCustomers; i++)
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

