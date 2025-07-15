// <copyright file="SQLInjectionService.cs" company="FooCorp">
// Copyright (c) FooCorp. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using Microsoft.Data.SqlClient;

namespace WebAPI.Services;

/// <summary>
/// Test.
/// </summary>
public class SQLInjectionService
{
    /// <summary>
    /// Test.
    /// </summary>
    /// <returns>.</returns>
    public string Made()
    {
        string? username = Console.ReadLine();
        string? password = Console.ReadLine();

        string connectionString = "your_connection_string_here";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            string query = $"SELECT * FROM Users WHERE Username = {username} AND Password = {password}";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        Console.WriteLine("Login successful!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid credentials.");
                    }
                }
            }
        }

        return "Ok";
    }
}
