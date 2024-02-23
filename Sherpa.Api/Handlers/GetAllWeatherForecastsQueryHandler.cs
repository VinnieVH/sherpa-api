using MediatR;
using Sherpa.Queries;
using Sherpa.Repositories;

namespace Sherpa.Handlers;

internal class GetAllWeatherForecastsQueryHandler(IWeatherForecastRepository weatherForecastRepository)
    : IRequestHandler<GetAllWeatherForecastsQuery, IEnumerable<WeatherForecast>>
{
    public Task<IEnumerable<WeatherForecast>> Handle(GetAllWeatherForecastsQuery request, CancellationToken cancellationToken)
    {
        return weatherForecastRepository.GetAll();
    }
}