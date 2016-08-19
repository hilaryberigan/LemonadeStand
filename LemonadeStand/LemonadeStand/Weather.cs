using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        string skyType;
        int temperature;
        string actualSkyType;
        int actualtemperature;
        Random random = new Random();
        List<string> skyTypes = new List<string>();

        public Weather()
        {
            SetTemperatureForecast();
            SetSkyTypeForecast();
            SetActualSkyType();
            SetActualTemperature();
        }
        //
        //forecast
        //
        public void SetWeatherForecast()
        {
            SetTemperatureForecast();
            SetSkyTypeForecast();
        }
        public void GetWeatherForecast()
        {
            Console.WriteLine("\nToday's weather forecast: \n");
            Console.WriteLine("\t" + GetSkyTypeForecast());
            Console.WriteLine("\t" + GettemperatureForecast() + "° F\n");
        }
        public void SetTemperatureForecast()
        {
            temperature = random.Next(50, 95);
        }

        public int GettemperatureForecast()
        {
            return temperature;
        }
        public void SetSkyTypeForecast()
        {
            
            skyTypes.Add("rainy");
            skyTypes.Add("cloudy");
            skyTypes.Add("sunny");


            skyType = skyTypes[random.Next(0, 2)];
        }
        public string GetSkyTypeForecast()
        {
           return skyType;
        }
        //
        //actual weather
        //
        public void SetActualWeather()
        {
           SetActualTemperature();
           SetActualSkyType();
        }
        public void GetActualWeather()
        {
            Console.WriteLine("Today's weather was: \n");
            Console.WriteLine("\t" + GetActualSkyType());
            Console.WriteLine("\t" + GetActualTemperature() + "° F\n");
        }
        public void SetActualSkyType()
        {
            if (random.Next(100) < 20)
            {
                actualSkyType = skyTypes[random.Next(0, 2)];
            }
            else
            {
                actualSkyType = skyType;
            }
        }
        public string GetActualSkyType()
        {
            return actualSkyType;
        }
        public void SetActualTemperature()
        {
            int randomNumber = random.Next(100);

            if (randomNumber < 20)
            {
                actualtemperature = temperature + random.Next(1, 5);
            }
            else if (randomNumber > 80)
            {
                actualtemperature = temperature - random.Next(1, 5);
            }
            else
            {
                actualtemperature = temperature;                
            }
        }
        public int GetActualTemperature()
        {
            return actualtemperature;
        }
    }
}

