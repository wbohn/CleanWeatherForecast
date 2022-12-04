using CleanWeatherForecast.Domain.Common;

namespace CleanWeatherForecast.Domain.Entities
{
    public class WeatherForecast : BaseEntity<int>
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; } = null!;
    }
}