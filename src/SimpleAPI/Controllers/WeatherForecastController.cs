using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers;

[ApiController]
[Route("shubham/[controller]")]
public class WeatherForecastController : ControllerBase
{

    [HttpGet]
    public double Get()
    {
        return 30.5;
    }
    
    [HttpGet("{id}")]
    public string Get(string id)
    {
        return "25.5 " + id;
    }

    [HttpPost(Name = "PostWeatherForecast")]
    public string Post()
    {
        return "Hello";
    }
}
