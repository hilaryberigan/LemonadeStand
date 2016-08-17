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
        public void Settemperature()
        {
            temperature = random.Next(50, 95);
        }

        public int Gettemperature()
        {
            return temperature;
        }
        public void SetSkyType()
        {
            
            skyTypes.Add("rainy");
            skyTypes.Add("cloudy");
            skyTypes.Add("sunny");


            skyType = skyTypes[random.Next(0, 2)];
        }
        public string GetSkyType()
        {
            SetSkyType();
            return skyType;
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

        public void GetMaxCustomers()
        {
           if (actualtemperature <= 60 && skyType == "rainy")
            {

            }
        }

    }
            
//generate actual weather for that day
        }

