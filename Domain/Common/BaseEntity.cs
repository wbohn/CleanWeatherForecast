namespace CleanWeatherForecast.Domain.Common
{
    public class BaseEntity<TId>
    {
        public TId Id { get; set; } = default!;
    }
}
