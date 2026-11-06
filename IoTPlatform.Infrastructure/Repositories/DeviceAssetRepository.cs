using Microsoft.EntityFrameworkCore;
using IoTPlatform.Application.Interfaces;
using IoTPlatform.Domain.Entities;
using IoTPlatform.Infrastructure.Data;

namespace IoTPlatform.Infrastructure.Repositories;

/// <summary>
/// This is the repository class for managing DeviceAsset entities.
/// It provides methods for CRUD operations on DeviceAsset entities.
/// </summary>
public class DeviceAssetRepository : IDeviceAssetRepository
{
    /// <summary>
    /// The database context for accessing DeviceAsset entities.
    /// </summary>
    private readonly IoTPlatformDbContext _context;

    /// <summary>
    /// Initializes a new instance of the DeviceAssetRepository class with the specified database context.
    /// </summary>
    /// <param name="context">The database context for accessing DeviceAsset entities.</param>
    public DeviceAssetRepository(IoTPlatformDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Gets a DeviceAsset entity by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the DeviceAsset entity.</param>
    /// <returns>The DeviceAsset entity if found; otherwise, null.</returns>
    public async Task<DeviceAsset?> GetByIdAsync(Guid id)
    {
        return await _context.DeviceAssets.FindAsync(id);
    }

    /// <summary>
    /// Gets all DeviceAsset entities.
    /// </summary>
    /// <returns>A collection of all DeviceAsset entities.</returns>
    public async Task<IEnumerable<DeviceAsset>> GetAllAsync()
    {
        return await _context.DeviceAssets.ToListAsync();
    }

    /// <summary>
    /// Adds a new DeviceAsset entity to the database.
    /// </summary>
    /// <param name="device">The DeviceAsset entity to add.</param>
    public async Task AddAsync(DeviceAsset device)
    {
        await _context.DeviceAssets.AddAsync(device);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Updates an existing DeviceAsset entity in the database.
    /// </summary>
    /// <param name="device">The DeviceAsset entity to update.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public async Task UpdateAsync(DeviceAsset device)
    {
        _context.DeviceAssets.Update(device);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Deletes a DeviceAsset entity by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the DeviceAsset entity to delete.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public async Task DeleteAsync(Guid id)
    {
        var device = await GetByIdAsync(id);

        if (device != null)
        {
            _context.DeviceAssets.Remove(device);
            await _context.SaveChangesAsync();
        }
    }
}