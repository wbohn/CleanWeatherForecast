using CleanWeatherForecast.Application.Common;
using CleanWeatherForecast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanWeatherForecast.Application.WeatherForecasts.Models
{
    public class WeatherForecastDto : IMapFrom<WeatherForecast>
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
