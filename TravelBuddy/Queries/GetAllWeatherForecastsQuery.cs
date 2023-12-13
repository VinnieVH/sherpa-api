using MediatR;

namespace TravelBuddy.Queries;

public class GetAllWeatherForecastsQuery : IRequest<IEnumerable<WeatherForecast>>
{
    
}