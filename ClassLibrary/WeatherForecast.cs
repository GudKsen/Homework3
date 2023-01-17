using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /*public class Class1
    {
        private string title;
        private string description;

        public Class1(string title, string description)
        {
            this.title = title;
            this.description = description;
        }

        public override string ToString()
        {
            return $"Title is {title}\nDescription is {description}";
        }
    }*/
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string Summary { get; set; }
    }
}
