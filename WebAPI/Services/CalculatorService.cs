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
    /// <param name="b">b</param>
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
        int[] x = [];
        Console.WriteLine(a);
        Console.WriteLine(string.Empty);
        return a + b;
    }
}
