﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Repository;

namespace ClassLibrary
{
    internal interface IDisplay
    {
        ArrayOfDaysWeather Month { get; set; }
    }
}
