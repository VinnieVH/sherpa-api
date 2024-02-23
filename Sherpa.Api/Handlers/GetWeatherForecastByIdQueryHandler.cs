using MediatR;
using Sherpa.Queries;
using Sherpa.Repositories;

namespace Sherpa.Handlers;

public class GetWeatherForecastByIdQueryHandler(IWeatherForecastRepository _weatherForecastRepository)
    : IRequestHandler<GetWeatherForecastByIdQuery, WeatherForecast?>
{
    public Task<WeatherForecast?> Handle(GetWeatherForecastByIdQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_weatherForecastRepository.GetById(request.Id));
    }
}