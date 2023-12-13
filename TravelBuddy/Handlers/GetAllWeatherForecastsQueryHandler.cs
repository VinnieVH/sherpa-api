using MediatR;
using TravelBuddy.Queries;
using TravelBuddy.Repositories;

namespace TravelBuddy.Handlers;

public class GetAllWeatherForecastsQueryHandler : IRequestHandler<GetAllWeatherForecastsQuery, IEnumerable<WeatherForecast>>
{
    private readonly WeatherForecastRepository _weatherForecastRepository = new();

    public Task<IEnumerable<WeatherForecast>> Handle(GetAllWeatherForecastsQuery request, CancellationToken cancellationToken)
    {
        return _weatherForecastRepository.GetAll();
    }
}