using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ArrayOfDaysWeather
    {
        private List<WeatherForecast> classes = new List<WeatherForecast>();
        public List<WeatherForecast> Classes { get { return classes; } }
    }
}
