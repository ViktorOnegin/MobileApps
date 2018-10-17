using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherApp.Core
{
    public class Forecast
    {
        public string data { get; set; } = " ";
        public string TemperatureMin { get; set; } = " ";
        public string TemperatureMax { get; set; } = " ";
        public string Icon { get; set; } = " ";
    }
}