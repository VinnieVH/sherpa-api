namespace TravelBuddy.Repositories;

public interface IWeatherForecastRepository
{
    public Task<IEnumerable<WeatherForecast>> GetAll();
    public WeatherForecast? GetById(Guid id);
}