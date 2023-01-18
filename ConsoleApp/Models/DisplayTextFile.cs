using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using ConsoleApp.Repository;

namespace ClassLibrary
{
    internal class DisplayTextFile : IDisplay
    {
        private ArrayOfDaysWeather month = new ArrayOfDaysWeather();
        public ArrayOfDaysWeather Month { get => month; set => month = value; }
        public void PrintToTextFile()
        {
            Console.WriteLine("Serialize, xml----------------------------------------------");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<WeatherForecast>));
            Stream fs = new FileStream("D:\\Lesson\\hw3.xml", FileMode.Create);
            XmlWriter xmlWriter = new XmlTextWriter(fs, Encoding.UTF8);
  
            xmlSerializer.Serialize(xmlWriter, month.ArrayWeather);
           
            xmlWriter.Close();
            Console.WriteLine("------------------------------------------------------------\n");


            Console.WriteLine("Deserialize, xml--------------------------------------------");
            ArrayOfDaysWeather arr = new ArrayOfDaysWeather();
         
            string str = File.ReadAllText("D:\\Lesson\\hw3.xml");

            using (TextReader reader = new StringReader(str))
            {
                arr.ArrayWeather = (List<WeatherForecast>)xmlSerializer.Deserialize(reader);
            }


            using (StreamWriter writetext = new StreamWriter("D:\\Lesson\\hw3.txt"))
            {
                for (int i = 0; i < arr.ArrayWeather.Count; i++)
                {
                    writetext.WriteLine(arr.ArrayWeather[i].ToString());
                }
            }

            Console.WriteLine("------------------------------------------------------------\n");
        }
    }
}
