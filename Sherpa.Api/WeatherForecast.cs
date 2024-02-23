namespace Sherpa;

public class WeatherForecast
{
    public Guid Id { get; init; }
    public DateOnly Date { get; set; }

    public int TemperatureC { get; init; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}