using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        int customerNumber;
        int personalThirst;
        bool willPay;
        int threshold;
        int weatherIndicator;
        decimal priceWillingToPay;
        int maxTemperature;
        bool boughtGlass;

        Random random = new Random();

        public Customer(int customerNumber)
        {
            personalThirst = random.Next(100);
            this.customerNumber = customerNumber;
            weatherIndicator = 0;
            maxTemperature = 100;
        }
        public int GetCustomerNumber()
        {
            return customerNumber;
        }
        public void SetPersonalThirst(int actualTemperature)
        {
            personalThirst = personalThirst + (maxTemperature / actualTemperature);
        }
        public void GetPreferences(decimal price, int actualTemperature, string actualSkyType)
        {
            SetWillPay(actualTemperature, price);
            SetWeatherIndicator(actualSkyType);
            SetPersonalThirst(actualTemperature);
            GetDecision();
        }
        public void SetWillPay(int actualTemperature, decimal price)
        {
            int minPriceWillingToPay = random.Next(0, 5);
            priceWillingToPay = ((decimal)actualTemperature / (decimal)maxTemperature) + (decimal)minPriceWillingToPay;
           

            if (priceWillingToPay >= price)
            {
                willPay = true;
            }
            else
            {
                willPay = false;
            }

        }
        public void SetWeatherIndicator(string actualSkyType)
        {
            
            if (actualSkyType == "sunny")
            {
               weatherIndicator = weatherIndicator + 50;
            }
            if (actualSkyType == "cloudy")
            {
                weatherIndicator = weatherIndicator + 20;
            }
            if (actualSkyType == "rainy")
            {
                weatherIndicator = weatherIndicator + 5;
            }
        }

        public decimal SetThreshold()
        {
            if (willPay == true)
            {
                threshold = personalThirst + weatherIndicator;
                return threshold;
            }
            else
            {
                return 0;
            }
        }
        public void GetDecision()
        {
            SetThreshold();

            if (threshold >= 100)
            {
                Console.WriteLine("Customer {0} buys lemonade", customerNumber);
                boughtGlass = true;
            }
            else
            {
                Console.WriteLine("Customer {0} walks by", customerNumber);
                boughtGlass = false;
            }
        }
       
        
        }
    }

