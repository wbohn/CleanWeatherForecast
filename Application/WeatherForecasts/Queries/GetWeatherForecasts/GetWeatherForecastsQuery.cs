using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanWeatherForecast.Application.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using CleanWeatherForecast.Application.WeatherForecasts.Models;

namespace CleanWeatherForecast.Application.WeatherForecasts.Queries.GetWeatherForecasts
{
    public class GetWeatherForecastsQuery : IRequest<ICollection<WeatherForecastDto>>
    {
    }

    public class GetWeatherForecastsQueryHandler : IRequestHandler<GetWeatherForecastsQuery, ICollection<WeatherForecastDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetWeatherForecastsQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ICollection<WeatherForecastDto>> Handle(GetWeatherForecastsQuery request, CancellationToken cancellationToken)
        {
            return await _context.WeatherForecasts
                .ProjectTo<WeatherForecastDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken: cancellationToken);
        }
    }
}
