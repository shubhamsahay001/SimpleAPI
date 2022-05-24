using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public class UnitTest1
{   
    WeatherForecastController controller = new WeatherForecastController();

    [Fact]
    public void GetReturnsData()
    {
        var returnValue = controller.Get();
        
        Assert.Equal("Welcome to the STM Demo - Group 6", returnValue);
    }

    [Fact]
       public void GetReturnsDataWithParam()
    {
        var returnValue = controller.Get("Ranchi");
        Assert.Equal("The average temparature in Ranchi will be 30.5 degree celsius in this week", returnValue);
    }
}