using MediatR;
using TravelBuddy.Queries;
using TravelBuddy.Repositories;

namespace TravelBuddy.Handlers;

public class GetWeatherForecastByIdQueryHandler : IRequestHandler<GetWeatherForecastByIdQuery, WeatherForecast?>
{
    private readonly WeatherForecastRepository _weatherForecastRepository = new();
    
    public Task<WeatherForecast?> Handle(GetWeatherForecastByIdQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_weatherForecastRepository.GetById(request.Id));
    }
}