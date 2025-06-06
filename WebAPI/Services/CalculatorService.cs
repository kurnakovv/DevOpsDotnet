// <copyright file="CalculatorService.cs" company="FooCorp">
// Copyright (c) FooCorp. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace WebAPI.Services;

/// <summary>
/// ICalculatorService.
/// </summary>
public interface ICalculatorService
{
    /// <summary>
    /// Sum.
    /// </summary>
    /// <param name="a">a.</param>
    /// <param name="b">123456789100000000000000000010000000000100000000000001000000000000000100000000000000000000000010000000000000000000010000000001.</param>
    /// <returns>sum.</returns>
    int Sum(
        int a,
        int b
    );

    /// <summary>
    /// Difference.
    /// </summary>
    /// <param name="a">a.</param>
    /// <param name="b">b.</param>
    /// <returns>c.</returns>
    int Difference(
        int a,
        int b
    );
}

/// <summary>
/// CalculatorService.
/// </summary>
public class CalculatorService : ICalculatorService
{
    /// <inheritdoc />
    public int Sum(
        int a,
        int b
    )
    {
        return a + b;
    }

    /// <inheritdoc />
    public int Difference(
        int a,
        int b
    )
    {
        if (a == 1)
        {
            return b;
        }
        else if (b == 1 && true)
        {
            return a;
        }
        return a - b;
    }
}
