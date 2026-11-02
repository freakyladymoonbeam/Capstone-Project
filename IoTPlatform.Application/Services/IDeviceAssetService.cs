using IoTPlatform.Application.DTOs;

namespace IoTPlatform.Application.Services;

/// <summary>
/// This interface defines the contract for a service that manages device assets.
/// It provides methods to retrieve device asset information.
/// </summary>
public interface IDeviceAssetService
{
    /// <summary>
    /// Retrieves all device assets.
    /// </summary>
    /// <returns>A collection of device asset DTOs.</returns>
    Task<IEnumerable<DeviceAssetDto>> GetAllDeviceAssetsAsync();
    
    /// <summary>
    /// Retrieves a device asset by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the device asset.</param>
    /// <returns>The device asset DTO if found; otherwise, null.</returns>
    Task<DeviceAssetDto?> GetDeviceAssetByIdAsync(Guid id);
}