using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public class UnitTest1
{   
    WeatherForecastController controller = new WeatherForecastController();

    [Fact]
    public void GetReturnsData()
    {
        var returnValue = controller.Get();
        
        Assert.Equal("<h1>Welcome to the STM Demo - Group 6</h1>", returnValue);
    }

    [Fact]
       public void GetReturnsDataWithParam()
    {
        var returnValue = controller.Get("Kolkata");
        Assert.Equal("25.5 Kolkata", returnValue);
    }
}