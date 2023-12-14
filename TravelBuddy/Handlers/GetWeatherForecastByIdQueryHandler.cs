using MediatR;
using TravelBuddy.Queries;
using TravelBuddy.Repositories;

namespace TravelBuddy.Handlers;

public class GetWeatherForecastByIdQueryHandler(IWeatherForecastRepository weatherForecastRepository)
    : IRequestHandler<GetWeatherForecastByIdQuery, WeatherForecast?>
{
    public Task<WeatherForecast?> Handle(GetWeatherForecastByIdQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(weatherForecastRepository.GetById(request.Id));
    }
}