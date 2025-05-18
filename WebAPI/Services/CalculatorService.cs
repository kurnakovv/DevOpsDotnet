namespace WebAPI.Services;

public interface ICalculatorService
{
    int Sum(
        int a,
        int b
    );
}

public class CalculatorService : ICalculatorService
{
    public int Sum(
        int a,
        int b
    )
    {
        return a + b;
    }
}
