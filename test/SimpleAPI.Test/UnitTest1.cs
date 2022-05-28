using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public class UnitTest1
{   
    WeatherForecastController controller = new WeatherForecastController();

    [Fact]
    public void GetReturnsData()
    {
        var returnValue = controller.Get();
        
        Assert.Equal("Good evening Welcome to the STM Demo - Group 6 is here with the demo", returnValue);
    }

    [Fact]
       public void GetReturnRanchiData()
    {
        var returnValue = controller.Get("Ranchi");
        Assert.Equal("The average temparature in Ranchi will be 30.5 degree celsius in next week", returnValue);
    }

    [Fact]
       public void GetReturnBangaloreData()
    {
        var returnValue = controller.Get("Bangalore");
        Assert.Equal("The average temparature in Bangalore will be 25.5 degree celsius in next week", returnValue);
    }

    [Fact]
       public void GetReturnBengaluruData()
    {
        var returnValue = controller.Get("Bengaluru");
        Assert.Equal("The average temparature in Bengaluru will be 25.5 degree celsius in next week", returnValue);
    }

    [Fact]
       public void GetReturnRandomData()
    {
        var returnValue = controller.Get("Random");
        Assert.Equal("Sorry we don't have the weather forecast data of Random in our servers yet.", returnValue);
    }
}