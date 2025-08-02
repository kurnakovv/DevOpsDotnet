// <copyright file="EFCoreTestService.cs" company="FooCorp">
// Copyright (c) FooCorp. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using Microsoft.EntityFrameworkCore;
using WebAPI.DB;

namespace WebAPI.Services;

/// <summary>
/// IEFCoreTestService test.
/// </summary>
public interface IEFCoreTestService
{
    /// <summary>
    /// Update.
    /// </summary>
    /// <returns>Nothing.</returns>
    Task UpdateAsync();
}

/// <summary>
/// EFCoreTestService.
/// </summary>
public class EFCoreTestService : IEFCoreTestService
{
    private readonly AppDbContext _appDbContext;

    /// <summary>
    /// EFCoreTestService.
    /// </summary>
    /// <param name="appDbContext">appDbContext.</param>
    public EFCoreTestService(
        AppDbContext appDbContext
    )
    {
        _appDbContext = appDbContext;
    }

    /// <inheritdoc />
    public async Task UpdateAsync()
    {
        await _appDbContext.Users.ExecuteUpdateAsync(x => x.SetProperty(x => x.Name, "vasia"));
    }
}
