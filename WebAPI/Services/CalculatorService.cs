namespace WebAPI.Services;

/// <summary>
/// ICalculatorService.
/// </summary>
public interface ICalculatorService
{
    /// <summary>
    /// Sum
    /// </summary>
    /// <param name="a">a</param>
    /// <param name="b">123456789100000000000000000010000000000100000000000001000000000000000100000000000000000000000010000000000000000000010000000001</param>
    /// <returns>sum</returns>
    int Sum(
        int a,
        int b
    );
}

/// <summary>
/// CalculatorService
/// </summary>
public class CalculatorService : ICalculatorService
{
    /// <inheritdoc />
    public int Sum(
        int a,
        int b
    )
    {
        Console.WriteLine("stryker test");
        Console.WriteLine("stryker test tttttttttffsda");
        return a + b;
    }
}
