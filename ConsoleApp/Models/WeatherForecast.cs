using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClassLibrary
{
    [XmlRoot("WeatherForecast")]
    public class WeatherForecast
    {
        [XmlElement("Date")]
        public DateTime Date { get; set; }

        [XmlElement("TemperatureCelsius")]
        public int TemperatureCelsius { get; set; }

        [XmlElement("Summary")]
        public string? Summary { get; set; }

        public override string ToString()
        {
            return $"Date: {Date}, Temperature: {TemperatureCelsius}, Summary: {Summary}";
        }
    }
}
