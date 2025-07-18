// <copyright file="TestController.cs" company="FooCorp">
// Copyright (c) FooCorp. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using Microsoft.AspNetCore.Mvc;
using WebAPI.Services;

namespace WebAPI.Controllers;

/// <summary>
/// Test.
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{
    private readonly ISQLInjectionService _sqlInjectionService;

    /// <summary>
    /// TestController.
    /// </summary>
    /// <param name="sqlInjectionService">sqlInjectionService.</param>
    public TestController(
        ISQLInjectionService sqlInjectionService
    )
    {
        _sqlInjectionService = sqlInjectionService;
    }

    /// <summary>
    /// Made.
    /// </summary>
    /// <param name="username">username.</param>
    /// <param name="password">password.</param>
    /// <returns>string.</returns>
    [HttpPost("Made")]
    public IActionResult Made(string username, string password)
    {
        string result = _sqlInjectionService.Made(username, password);
        return Ok(result);
    }

    /// <summary>
    /// Made.
    /// </summary>
    /// <param name="columnname">columnname.</param>
    /// <returns>string.</returns>
    [HttpPost("ExecuteQuery")]
    public IActionResult ExecuteQuery(string columnname)
    {
        _sqlInjectionService.ExecuteQuery(columnname);
        return Ok();
    }
}
