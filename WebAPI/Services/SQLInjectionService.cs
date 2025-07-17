// <copyright file="SQLInjectionService.cs" company="FooCorp">
// Copyright (c) FooCorp. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;

namespace WebAPI.Services;

/// <summary>
/// Test.
/// </summary>
public class SQLInjectionService
{
    private static readonly Regex ColumnNameRegex = new Regex("^[a-zA-Z0-9_]+$");

    /// <summary>
    /// Test.
    /// </summary>
    /// <param name="username">.</param>
    /// <param name="password">fd.</param>
    /// <returns>fddfs.</returns>
    public string Made(string username, string password)
    {
        // Local Regex variable declaration
        Regex localColumnNameRegex = ColumnNameRegex;

        if (!localColumnNameRegex.IsMatch(username))
        {
            throw new ArgumentException("Invalid column name");
        }

        if (!localColumnNameRegex.IsMatch(password))
        {
            throw new ArgumentException("Invalid column name");
        }

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

    /// <summary>
    /// Test.
    /// </summary>
    /// <param name="columnName">ffdsf.</param>
    /// <exception cref="ArgumentException">dfas.</exception>
    public void ExecuteQuery(string columnName)
    {
        // Local Regex variable declaration
        Regex localColumnNameRegex = ColumnNameRegex;

        if (!localColumnNameRegex.IsMatch(columnName))
        {
            throw new ArgumentException("Invalid column name");
        }

        string query = $"SELECT {columnName} FROM Users";
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
    }
}
