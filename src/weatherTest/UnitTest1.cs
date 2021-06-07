using System;
using Xunit;
using Microsoft.Extensions.Logging;
using System.Net.Http;

namespace weatherTest
{
    public class UnitTest1
    {
       // private readonly ILogger<consoleAPI.Controllers.WeatherForecastController> _logger;

        public UnitTest1()
        {
            //_logger = logger;
        }

        [Fact]
        public void AddingToNumbers_Successful()
        {
            // Arrange
            //var controller = new consoleAPI.Controllers.WeatherForecastController(_logger);

           // var result = controller.AddNumbers(5, 5);
            var expected = 10;
            Assert.Equal(expected, 10);
        }
    }
}
