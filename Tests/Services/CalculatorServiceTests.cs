// <copyright file="CalculatorServiceTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using WebAPI.Services;

namespace Tests.Services;

/// <summary>
/// CalculatorServiceTests.
/// </summary>
public class CalculatorServiceTests
{
    /// <summary>
    /// Sum_FivePlusFive_Ten test.
    /// </summary>
    [Fact]
    public void Sum_FivePlusFive_Ten()
    {
        ICalculatorService calculatorService = new CalculatorService();

        int result = calculatorService.Sum(5, 5);

        Assert.Equal(10, result);
        Assert.NotEqual(15, result);
    }

    /// <summary>
    /// Difference_TenMinusFive_Ten.
    /// </summary>
    [Fact]
    public void Difference_TenMinusFive_Ten()
    {
        ICalculatorService calculatorService = new CalculatorService();

        int result = calculatorService.Difference(10, 5);

        Assert.Equal(5, result);
        Assert.NotEqual(15, result);
    }

    /// <summary>
    /// Difference_IfCases_Result.
    /// </summary>
    [Fact]
    public void Difference_IfACases_Result()
    {
        ICalculatorService calculatorService = new CalculatorService();

        int result = calculatorService.Difference(1, 5);

        Assert.Equal(5, result);
        Assert.NotEqual(15, result);
    }

    /// <summary>
    /// Difference_IfBCases_Result.
    /// </summary>
    [Fact]
    public void Difference_IfBCases_Result()
    {
        ICalculatorService calculatorService = new CalculatorService();

        int result = calculatorService.Difference(5, 1);

        Assert.Equal(5, result);
        Assert.NotEqual(15, result);
    }
}
