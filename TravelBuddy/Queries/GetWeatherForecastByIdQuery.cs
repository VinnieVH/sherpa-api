using MediatR;

namespace TravelBuddy.Queries;

public class GetWeatherForecastByIdQuery : IRequest<WeatherForecast>
{
    public GetWeatherForecastByIdQuery(int id)
    {
        Id = id;
    }

    public int Id { get; }
}