using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DisplayConsole : IDisplay
    {
        private ArrayOfDaysWeather month = new ArrayOfDaysWeather();
        public ArrayOfDaysWeather Month { get => month; set => month = value; }

        public void PrintToCnsole()
        {
            for (int i = 0; i < 30; i++)
            {
                DateTime date = DateTime.UtcNow.Date;
                var weatherForecast = new WeatherForecast
                {
                    Date = date,
                    TemperatureCelsius = 25,
                    Summary = "Hot"
                };
                string jsonString = JsonSerializer.Serialize(weatherForecast);
                Console.WriteLine(jsonString);
            }
        }
    }
}
