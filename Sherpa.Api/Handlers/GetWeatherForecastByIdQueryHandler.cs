using MediatR;
using TravelBuddy.Queries;
using TravelBuddy.Repositories;

namespace TravelBuddy.Handlers;

public class GetWeatherForecastByIdQueryHandler(IWeatherForecastRepository _weatherForecastRepository)
    : IRequestHandler<GetWeatherForecastByIdQuery, WeatherForecast?>
{
    public Task<WeatherForecast?> Handle(GetWeatherForecastByIdQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_weatherForecastRepository.GetById(request.Id));
    }
}