using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class DisplayTextFile : IDisplay
    {
        private ArrayOfDaysWeather Class2Array = new ArrayOfDaysWeather();
        public ArrayOfDaysWeather Month { get => Class2Array; set => Class2Array = value; }
        public void PrintToTextFile()
        {
            foreach (var item in Class2Array.Classes)
            {
                File.WriteAllText("D:\\Lesson\\hw3.txt", item.ToString());
            }
        }
    }
}
