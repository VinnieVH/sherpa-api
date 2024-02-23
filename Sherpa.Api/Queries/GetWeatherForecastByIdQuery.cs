using MediatR;

namespace Sherpa.Queries;

public class GetWeatherForecastByIdQuery(Guid id) : IRequest<WeatherForecast?>
{
    public Guid Id { get; } = id;
}