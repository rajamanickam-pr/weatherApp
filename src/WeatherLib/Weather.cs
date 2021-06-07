using System;
using System.Collections.Generic;
using System.Linq;

namespace WeatherLib
{
    public class Weather
    {
        public IEnumerable<WeatherForecast> GetWeather()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55)
            })
           .ToArray();
        }
    }
}
