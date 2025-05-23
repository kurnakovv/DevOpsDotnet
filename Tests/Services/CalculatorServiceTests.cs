using WebAPI.Services;

namespace Tests.Services;

/// <summary>
/// CalculatorServiceTests
/// </summary>
public class CalculatorServiceTests
{
    /// <summary>
    /// Sum_FivePlusFive_Ten
    /// </summary>
    [Fact]
    public void Sum_FivePlusFive_Ten()
    {
        ICalculatorService calculatorService = new CalculatorService();

        int result = calculatorService.Sum(5, 5);

        Assert.Equal(10, result);
        Assert.NotEqual(15, result);
    }
}
