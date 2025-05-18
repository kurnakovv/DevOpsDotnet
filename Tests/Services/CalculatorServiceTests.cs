using WebAPI.Services;

namespace Tests.Services;

public class CalculatorServiceTests
{
    [Fact]
    public void Sum_FivePlusFive_Ten()
    {
        ICalculatorService calculatorService = new CalculatorService();

        var result = calculatorService.Sum(5, 5);

        Assert.Equal(10, result);
        Assert.NotEqual(15, result);
    }
}
