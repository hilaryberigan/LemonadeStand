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
        int tempurature;
        Random random = new Random();
        public int SetTempurature()
        {
            tempurature = random.Next(50, 95);
            return tempurature;
        }
        public string SetSkyType()
        {
            List<string> skyTypes = new List<string>();
            skyTypes.Add("cloudy");
            skyTypes.Add("overcast");
            skyTypes.Add("sunny");
            skyTypes.Add("mostly sunny");
            skyTypes.Add("rainy");

            skyType = skyTypes[random.Next(0, 4)];
            return skyType;
        }
        public void GetWeather()
        {
            Console.WriteLine("Today's weather: ");
            Console.WriteLine(SetSkyType());
            Console.WriteLine(SetTempurature() + " degrees F");
        }

    }
            
//generate actual weather for that day
        }

