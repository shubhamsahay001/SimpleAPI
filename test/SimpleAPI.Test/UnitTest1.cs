using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public class UnitTest1
{   
    WeatherForecastController controller = new WeatherForecastController();

    [Fact]
    public void GetReturnsData()
    {
        var returnValue = controller.Get();
        Assert.Equal(30.5, returnValue);
    }

    [Fact]
       public void GetReturnsDataWithParam()
    {
        var returnValue = controller.Get("Bangalore");
        Assert.Equal("25.5 Bangalore", returnValue);
    }
}