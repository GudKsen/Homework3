using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ArrayOfDaysWeather
    {
        private List<WeatherForecast> array_weather = new List<WeatherForecast>();
        public List<WeatherForecast> ArrayWeather { get { return array_weather; } set { array_weather = value; } }
    }
}
