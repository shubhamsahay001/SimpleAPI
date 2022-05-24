using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers;

[ApiController]
[Route("shubham/[controller]")]
public class WeatherForecastController : ControllerBase
{

    [HttpGet]
    public string Get()
    {
        return "Welcome to the STM Demo - Group 6";
    }
    
    [HttpGet("{id}")]
    public string Get(string id)
    {
        if(id=="Ranchi")
        return "The average temparature in "+id+ " will be "+"30.5 degree celsius in this week";
        else
        if(id=="Bangalore" || id=="Bengaluru")
        return "The average temparature in "+id+ " will be "+"25.5 degree celsius in this week";

        return "Sorry we don't have the weather forecast data of "+id+" in our servers yet.";
    }

    [HttpPost(Name = "PostWeatherForecast")]
    public string Post()
    {
        return "Hello World";
    }
}
