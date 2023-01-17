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
            for (int i = 0; i < month.ArrayWeather.Count; i++)
            {
                Console.WriteLine("Serialize, json--------------------------------------------------");
                string jsonString = JsonSerializer.Serialize(month.ArrayWeather[i]);
                Console.WriteLine(jsonString);
                Console.WriteLine("-----------------------------------------------------------------\n");

                Console.WriteLine("Deserialize, json------------------------------------------------");
                WeatherForecast? weatherForecast = JsonSerializer.Deserialize<WeatherForecast>(jsonString);
                Console.WriteLine(weatherForecast);
                Console.WriteLine("-----------------------------------------------------------------\n");
            }
        }
    }
}
