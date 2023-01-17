using ClassLibrary;
using System.Text.Json;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayOfDaysWeather month = new ArrayOfDaysWeather();
            for (int i = 0; i < 3; i++)
            {
                month.ArrayWeather.Add(new WeatherForecast
                {
                    Date = DateTime.Now,
                    TemperatureCelsius = 25,
                    Summary = "hot"
                });
            }

            DisplayConsole dc = new DisplayConsole();
            dc.Month = month;
            dc.PrintToCnsole();

            DisplayTextFile dt = new DisplayTextFile();
            dt.Month = month;
            dt.PrintToTextFile();
        }
    }
}