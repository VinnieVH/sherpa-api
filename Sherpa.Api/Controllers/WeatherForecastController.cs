using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravelBuddy.Queries;

namespace TravelBuddy.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class WeatherForecastController(ISender mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var weatherForecasts = await mediator.Send(new GetAllWeatherForecastsQuery());
        return Ok(weatherForecasts);
    }
    
    [HttpGet]
    [Route("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        var result = await mediator.Send(new GetWeatherForecastByIdQuery(id));
        return result != null ? Ok(result) : NotFound();
    }
}