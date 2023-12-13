using MediatR;

namespace TravelBuddy.Queries.GetAllWeatherForecastsQuery;

public class GetAllWeatherForecastsQuery : IRequest<IEnumerable<WeatherForecast>>
{
    
}