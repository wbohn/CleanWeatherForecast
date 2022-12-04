using MediatR;
using Microsoft.AspNetCore.Mvc;
using CleanWeatherForecast.Application.WeatherForecasts.Models;
using CleanWeatherForecast.Application.WeatherForecasts.Queries.GetWeatherForecasts;

namespace CleanWeatherForecast.Api.Controllers
{
    public class WeatherForecastController : BaseController
    {
        public WeatherForecastController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet(Name = "GetWeatherForecasts")]
        public async Task<IEnumerable<WeatherForecastDto>> Get()
        {
            return await _mediator.Send(new GetWeatherForecastsQuery());
        }
    }
}