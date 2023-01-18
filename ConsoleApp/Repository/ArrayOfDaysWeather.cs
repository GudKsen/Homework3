using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp.Repository
{
    public class ArrayOfDaysWeather : IRepository
    {
        private List<WeatherForecast> array_weather = new List<WeatherForecast>();
        public List<WeatherForecast> ArrayWeather { get { return array_weather; } set { array_weather = value; } }

        public void Add(WeatherForecast day)
        {
            array_weather.Add(day);
        }
    }
}
