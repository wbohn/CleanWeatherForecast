using Microsoft.EntityFrameworkCore;
using CleanWeatherForecast.Domain.Entities;

namespace CleanWeatherForecast.Application.Common
{
    public interface IApplicationDbContext
    {
        DbSet<WeatherForecast> WeatherForecasts { get; set; }
    }
}
