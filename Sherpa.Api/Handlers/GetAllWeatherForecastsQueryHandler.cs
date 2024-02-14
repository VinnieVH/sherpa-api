using MediatR;
using TravelBuddy.Queries;
using TravelBuddy.Repositories;

namespace TravelBuddy.Handlers;

internal class GetAllWeatherForecastsQueryHandler(IWeatherForecastRepository weatherForecastRepository)
    : IRequestHandler<GetAllWeatherForecastsQuery, IEnumerable<WeatherForecast>>
{
    public Task<IEnumerable<WeatherForecast>> Handle(GetAllWeatherForecastsQuery request, CancellationToken cancellationToken)
    {
        return weatherForecastRepository.GetAll();
    }
}