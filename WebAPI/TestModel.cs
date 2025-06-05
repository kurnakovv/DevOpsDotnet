// <copyright file="TestModel.cs" company="FooCorp">
// Copyright (c) FooCorp. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace WebAPI;

/// <summary>
/// Test.
/// </summary>
public class TestModel
{
    /// <summary>
    /// Gets or sets tst.
    /// </summary>
    public int MyProperty { get; set; }

    /// <summary>
    /// Gets or sets test.
    /// </summary>
    public string? MyProperty2
    {
        get; set;
    }

    /// <summary>
    /// MyProperty3.
    /// </summary>
    public decimal MyProperty3 { get; set; }
}
