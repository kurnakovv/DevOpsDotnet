// <copyright file="UserService.cs" company="FooCorp">
// Copyright (c) FooCorp. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace WebAPI.Services;

/// <summary>
/// UserService test.
/// </summary>
public class UserService
{
    private const string MY_TEST_STR = "kekw";

    private readonly ICalculatorService _calculatorService;

    /// <summary>
    /// Test.
    /// </summary>
    /// <param name="calculatorService">test.</param>
    public UserService(
        ICalculatorService calculatorService
    )
    {
        _calculatorService = calculatorService;
    }

    /// <summary>
    /// Sum age.
    /// </summary>
    /// <returns>sum age.</returns>
    public async Task<int> SumAge()
    {
        int result = _calculatorService.Sum(
            a: int.MaxValue,
            b: int.MinValue
        );
        await Task.Delay(1);
        Print();
        return result;
    }

    /// <summary>
    /// dfsa.
    /// </summary>
    public static void Print()
    {
        Console.WriteLine(MY_TEST_STR);
    }
}
