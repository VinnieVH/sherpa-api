using MediatR;

namespace Sherpa.Queries;

public class GetAllWeatherForecastsQuery : IRequest<IEnumerable<WeatherForecast>>
{
    
}