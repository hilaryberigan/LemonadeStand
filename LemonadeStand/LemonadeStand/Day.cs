using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        int dayNumber;
        Weather weather = new Weather();

        public Day()
        {
        
        }
        public void GenerateConditions()
        {

        }

        public void GetWeatherForecast()
        {
            Console.WriteLine("\nToday's weather forecast: ");
            Console.WriteLine(weather.SetSkyType());
            Console.WriteLine(weather.SetTempurature() + " degrees F");
        }

        public int GetDayNumber()
        {
            return dayNumber;
        }
        public void GoToNextDay()
        {
            dayNumber++;
        }
    }
}
