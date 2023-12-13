namespace TravelBuddy.Repositories;

public class WeatherForecastRepository
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    
    private readonly IEnumerable<WeatherForecast> _weatherForecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
    {
        Id = index,
        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        TemperatureC = Random.Shared.Next(-20, 55),
        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    });

    public Task<IEnumerable<WeatherForecast>> GetAll()
    {
        return Task.FromResult(_weatherForecasts);
    }

    public WeatherForecast? GetById(int id)
    {
        return _weatherForecasts.FirstOrDefault(x => x.Id == id);
    }
    
    
}