using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WeatherApp.Core
{
    public class Weather
    {
        public string Temperature { get; set; } = " ";
        public string WindSpeed { get; set; } = " ";
        public string pressure { get; set; } = " ";
        public string Visibility { get; set; } = " ";
        public string Humidity { get; set; } = " ";
    }
}