using NSubstitute;

namespace platformEngineering.WebApi.Unit.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [Test]
    public void weatherEndpoint_WhenTempZero_ShouldReturnWeatherForecast32()
    {
        //Arrange
        var temp = 0;
        
        //Act
        var result = new WeatherForecast(DateOnly.FromDateTime(DateTime.Now), temp, "");

        Assert.That(result.TemperatureF, Is.EqualTo(32));
    }
    
    [Test]
    public void weatherEndpoint_WhenTemp100_ShouldReturnWeatherForecast212()
    {
        //Arrange
        var temp = 100;
        
        //Act
        var result = new WeatherForecast(DateOnly.FromDateTime(DateTime.Now), temp, "");

        Assert.That(result.TemperatureF, Is.EqualTo(211));
    }
}
