// <copyright file="AppDbContext.cs" company="FooCorp">
// Copyright (c) FooCorp. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using Microsoft.EntityFrameworkCore;

namespace WebAPI.DB;

/// <summary>
/// AppDbContext.
/// </summary>
public class AppDbContext : DbContext
{
    /// <summary>
    /// Test.
    /// </summary>
    /// <param name="options">dfsdfas.</param>
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();   // создаем базу данных при первом обращении
    }

    /// <summary>
    /// Users.
    /// </summary>
    public required DbSet<User> Users { get; set; }
}
