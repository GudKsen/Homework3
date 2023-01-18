using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Repository
{
    internal interface IRepository
    {
        void Add(WeatherForecast day);
    }
}
