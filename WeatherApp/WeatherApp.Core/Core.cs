using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Core
{
    public class Core
    {
        public static async Task<Weather> GetWeather(string city)
        {
            string key = "1dad50e251b03e9137b8b650a95bc9ff";
            string queryString = "http://api.openweathermap.org/data/2.5/weather?q="+ city +"&units=metric&appid="+ key;

            dynamic results = await DataService.GetDataFromService(queryString).ConfigureAwait(false);

            var weather = new Weather();
            weather.Temperature = (string)results["main"]["temp"] + " °C";
            weather.WindSpeed = (string)results["wind"]["speed"] + " m/s";
            weather.pressure = (string)results["main"]["pressure"] + " hpa";
            weather.Visibility = (string)results["weather"][0]["main"];
            weather.Humidity = (string)results["main"]["humidity"] + " %";
            weather.Icon = (string)results["weather"][0]["icon"];

            return weather;
        }

        public static async Task<Forecast[]> GetForecast(string city)
        {
            string key = "1dad50e251b03e9137b8b650a95bc9ff";
            string queryString = "http://api.openweathermap.org/data/2.5/forecast?q=" + city + "&units=metric&appid=" + key;

            dynamic results = await DataService.GetDataFromService(queryString).ConfigureAwait(false);

            var forecast = new Forecast();
            forecast.TemperatureMin = (string)results["list"][0]["main"]["temp_low"] + " °C";
            forecast.TemperatureMax = (string)results["list"][0]["main"]["temp_max"] + " °C";
            forecast.Icon = (string)results["list"][0]["weather"][0]["icon"];

            var forecasts = new Forecast[1];
            forecasts[0] = forecast;

            return forecasts;
        }
    }
}
