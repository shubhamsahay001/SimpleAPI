using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers;

[ApiController]
[Route("shubham/[controller]")]
public class WeatherForecastController : ControllerBase
{

    [HttpGet]
    public string Get()
    {
        return "<h1>Welcome to the STM Demo - Group 6</h1>";
    }
    
    [HttpGet("{id}")]
    public string Get(string id)
    {
        return "25.5 " + id;
    }

    [HttpPost(Name = "PostWeatherForecast")]
    public string Post()
    {
        return "Hello World";
    }
}
