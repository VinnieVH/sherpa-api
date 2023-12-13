using System.ComponentModel.DataAnnotations;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TravelBuddy.Queries;

namespace TravelBuddy.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;

    private readonly ISender _mediator;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, ISender mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var weatherForecasts = await _mediator.Send(new GetAllWeatherForecastsQuery());
        return Ok(weatherForecasts);
    }
    
    [HttpGet]
    [Route("{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        var result = await _mediator.Send(new GetWeatherForecastByIdQuery(id));
        return result != null ? Ok(result) : NotFound();
    }
}