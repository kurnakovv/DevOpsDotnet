namespace WebAPI.Services;

/// <summary>
/// UserService
/// </summary>
public class UserService
{
    private const string MY_TEST_STR = "kekw";

    private readonly ICalculatorService _calculatorService;

    /// <summary>
    /// UserService
    /// </summary>
    public UserService(
        ICalculatorService calculatorService
    )
    {
        _calculatorService = calculatorService;
    }

    /// <summary>
    /// SumAge
    /// </summary>
    /// <returns>sum age</returns>
    public async Task<int> SumAge()
    {
        Console.WriteLine("kek lol chebureq");
        int result = _calculatorService.Sum(
            a: int.MaxValue,
            b: int.MinValue
        );
        await Task.Delay(1);
        Print();
        return result;
    }

    /// <summary>
    /// dfsa
    /// </summary>
    public static void Print()
    {
        Console.WriteLine(MY_TEST_STR);
    }
}
