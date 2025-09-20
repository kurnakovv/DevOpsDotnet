// <copyright file="TestController.cs" company="FooCorp">
// Copyright (c) FooCorp. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
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
    private readonly IEFCoreTestService _efCoreTestService;

    /// <summary>
    /// TestController.
    /// </summary>
    /// <param name="sqlInjectionService">sqlInjectionService.</param>
    /// <param name="efCoreTestService">efCoreTestService.</param>
    public TestController(
        ISQLInjectionService sqlInjectionService,
        IEFCoreTestService efCoreTestService
    )
    {
        _sqlInjectionService = sqlInjectionService;
        _efCoreTestService = efCoreTestService;
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
    /// ExecuteQuery.
    /// </summary>
    /// <param name="columnname">columnname.</param>
    /// <returns>string.</returns>
    [HttpPost("ExecuteQuery")]
    public IActionResult ExecuteQuery(string columnname)
    {
        _sqlInjectionService.ExecuteQuery(columnname);
        return Ok();
    }

    /// <summary>
    /// ExecuteQuery2.
    /// </summary>
    /// <param name="columnname">columnname.</param>
    /// <returns>string.</returns>
    [HttpPost("ExecuteQuery2")]
    public IActionResult ExecuteQuery2(string columnname)
    {
        string query = $"SELECT {columnname} FROM Users";
        using (SqlConnection connection = new SqlConnection("your_connection_string"))
        {
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0]);
            }
        }
        return Ok();
    }

    /// <summary>
    /// Update.
    /// </summary>
    /// <returns>Nothing.</returns>
    [HttpPut("Update")]
    public async Task<IActionResult> Update()
    {
        await _efCoreTestService.UpdateAsync();
        return Ok();
    }

    /// <summary>
    /// MissedWhere.
    /// </summary>
    /// <returns>.</returns>
    [HttpGet("MissedWhere")]
    public IActionResult MissedWhere()
    {
        List<int> lst = Enumerable.Range(1, 10).ToList();

        foreach (int i in lst)
        {
            if (i % 2 != 0)
            {
                continue;
            }
            Console.WriteLine(i);
            Console.WriteLine(i / 2);
        }

        foreach (int i in lst)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
                Console.WriteLine(i / 2);
            }
            if (i == 5)
            {
                Console.WriteLine(i);
            }
        }

        return Ok();
    }
}
