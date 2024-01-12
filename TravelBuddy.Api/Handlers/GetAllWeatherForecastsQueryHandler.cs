using MediatR;
using TravelBuddy.Queries;
using TravelBuddy.Repositories;

namespace TravelBuddy.Handlers;

public class GetAllWeatherForecastsQueryHandler(IWeatherForecastRepository _weatherForecastRepository)
    : IRequestHandler<GetAllWeatherForecastsQuery, IEnumerable<WeatherForecast>>
{
    public Task<IEnumerable<WeatherForecast>> Handle(GetAllWeatherForecastsQuery request, CancellationToken cancellationToken)
    {
        return _weatherForecastRepository.GetAll();
    }
}