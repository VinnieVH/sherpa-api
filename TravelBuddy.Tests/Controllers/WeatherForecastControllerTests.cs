using MediatR;
using Moq;
using TravelBuddy.Api.Controllers;
using TravelBuddy.Repositories;

namespace TravelBuddy.Tests.Controllers;

public class WeatherForecastControllerTests(WeatherForecastController weatherForecastController)
{
    [Fact]
    public async void GetAll_ShouldReturn_200()
    {
        // Arrange
        var mediator = new Mock<ISender>();
        var mockRepo = new Mock<IWeatherForecastRepository>();
        mockRepo.Setup(repo => repo.GetAll())
            .ReturnsAsync(GetWeatherForecasts());
        var controller = new WeatherForecastController(mediator);
        
        // Act
        var result = await controller.GetAll();
        
        // Assert
        Assert.Equal();
        
        
    }

    private static IEnumerable<WeatherForecast> GetWeatherForecasts()
    {
        return Enumerable.Range(1, 2).Select(index => new WeatherForecast
        {
            Id = Guid.NewGuid(),
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = 25,
            Summary = "Warm"
        });
    }
}