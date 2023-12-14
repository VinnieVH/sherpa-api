using MediatR;

namespace TravelBuddy.Queries;

public class GetWeatherForecastByIdQuery(Guid id) : IRequest<WeatherForecast?>
{
    public Guid Id { get; } = id;
}