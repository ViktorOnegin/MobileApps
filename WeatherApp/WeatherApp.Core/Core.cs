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
            string queryString = "http://api.openweathermap.org/data/2.5/weather?q=" + city + "&units=metric&appid=" + key;

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

            var forecast1 = new Forecast();
            forecast1.TemperatureMin = (string)results["list"][1]["main"]["temp_min"] + " °C";
            forecast1.TemperatureMax = (string)results["list"][1]["main"]["temp_max"] + " °C";
            forecast1.Icon = (string)results["list"][1]["weather"][0]["icon"];

            DateTime time1 = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            DateTime date1 = time1.AddSeconds((double)results["list"][1]["dt"]);
            forecast1.data = date1.ToString();

            var forecast2 = new Forecast();
            forecast2.TemperatureMin = (string)results["list"][9]["main"]["temp_min"] + " °C";
            forecast2.TemperatureMax = (string)results["list"][9]["main"]["temp_max"] + " °C";
            //forecast2.Icon = (string)results["list"][9]["weather"][0]["icon"];

            DateTime time2 = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            DateTime date2 = time2.AddSeconds((double)results["list"][9]["dt"]);
            forecast2.data = date2.ToString();

            var forecast3 = new Forecast();
            forecast3.TemperatureMin = (string)results["list"][17]["main"]["temp_min"] + " °C";
            forecast3.TemperatureMax = (string)results["list"][17]["main"]["temp_max"] + " °C";
            //forecast3.Icon = (string)results["list"][17]["weather"][0]["icon"];

            DateTime time3 = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            DateTime date3 = time3.AddSeconds((double)results["list"][17]["dt"]);
            forecast3.data = date3.ToString();

            var forecast4 = new Forecast();
            forecast4.TemperatureMin = (string)results["list"][25]["main"]["temp_min"] + " °C";
            forecast4.TemperatureMax = (string)results["list"][25]["main"]["temp_max"] + " °C";
            //forecast4.Icon = (string)results["list"][25]["weather"][0]["icon"];

            DateTime time4 = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            DateTime date4 = time4.AddSeconds((double)results["list"][25]["dt"]);
            forecast4.data = date4.ToString();

            var forecast5 = new Forecast();
            forecast5.TemperatureMin = (string)results["list"][33]["main"]["temp_min"] + " °C";
            forecast5.TemperatureMax = (string)results["list"][33]["main"]["temp_max"] + " °C";
            //forecast5.Icon = (string)results["list"][33]["weather"][0]["icon"];

            DateTime time5 = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            DateTime date5 = time5.AddSeconds((double)results["list"][33]["dt"]);
            forecast5.data = date5.ToString();

            var forecasts = new Forecast[5];
            forecasts[0] = forecast1;
            forecasts[1] = forecast2;
            forecasts[2] = forecast3;
            forecasts[3] = forecast4;
            forecasts[4] = forecast5;

            return forecasts;
        }
    }
}
