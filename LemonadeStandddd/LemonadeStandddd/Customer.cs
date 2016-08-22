using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandddd
{

    class Customer
    {
        int personalThirst;
        bool willPay;
        int threshold;
        int weatherIndicator;
        decimal priceWillingToPay;
        int maxTemperature = 100;
        public bool wantsGlass;

        Random random = new Random();

        public Customer(Weather weather, decimal price)
        {
            personalThirst = random.Next(100);
            weatherIndicator = 0;
            SetPreferences(price, weather.GetActualTemperature(), weather.GetActualSkyType());
        }
        //
        //SetPreferences
        //
        public void SetPersonalThirst(int actualTemperature)
        {
            personalThirst = personalThirst + (maxTemperature / actualTemperature);
        }

        public void SetWillPay(int actualTemperature, decimal price)
        {
            int minPriceWillingToPay = random.Next(1, 5);
            priceWillingToPay = ((decimal)actualTemperature / (decimal)maxTemperature) * (decimal)minPriceWillingToPay;


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
                weatherIndicator = weatherIndicator + 60;
            }
            if (actualSkyType == "cloudy")
            {
                weatherIndicator = weatherIndicator + 40;
            }
            if (actualSkyType == "rainy")
            {
                weatherIndicator = weatherIndicator + 20;
            }
        }
        public void SetPreferences(decimal price, int actualTemperature, string actualSkyType)
        {
            SetWillPay(actualTemperature, price);
            SetWeatherIndicator(actualSkyType);
            SetPersonalThirst(actualTemperature);
            GetDecision();
        }
        //
        //decision
        //
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
                wantsGlass = true;
            }
        }
    }
}



