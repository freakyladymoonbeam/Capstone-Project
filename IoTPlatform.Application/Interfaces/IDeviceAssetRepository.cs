using IoTPlatform.Domain.Entities;

namespace IoTPlatform.Application.Interfaces;

/// <summary>
/// This is the repository interface for managing DeviceAsset entities.
/// It provides methods for CRUD operations on DeviceAsset entities.
/// </summary>
public interface IDeviceAssetRepository
{
    /// <summary>
    /// Gets a DeviceAsset by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the DeviceAsset.</param>
    /// <returns>The DeviceAsset if found; otherwise, null.</returns>
    Task<DeviceAsset?> GetByIdAsync(Guid id);
    
    /// <summary>
    /// Gets all DeviceAsset entities.
    /// </summary>
    /// <returns>A collection of all DeviceAsset entities.</returns>
    Task<IEnumerable<DeviceAsset>> GetAllAsync();
    
    /// <summary>
    /// Adds a new DeviceAsset entity.
    /// </summary>
    /// <param name="device">The DeviceAsset entity to add.</param>
    Task AddAsync(DeviceAsset device);
    
    /// <summary>
    /// Updates an existing DeviceAsset entity.
    /// </summary>
    /// <param name="device">The DeviceAsset entity to update.</param>
    Task UpdateAsync(DeviceAsset device);

    /// <summary>
    /// Deletes a DeviceAsset entity by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the DeviceAsset to delete.</param>
    /// <returns>A task representing the asynchronous delete operation.</returns>
    Task DeleteAsync(Guid id);
}