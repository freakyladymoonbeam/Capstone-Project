namespace IoTPlatform.Application.DTOs;

/// <summary>
/// This class represents a Data Transfer Object (DTO) for a device 
/// asset, containing its basic properties.
/// </summary>
public class DeviceAssetDto
{
    /// <summary>
    /// The unique identifier of the device asset.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The serial number of the device asset.
    /// </summary>
    public string SerialNumber { get; set; } = string.Empty;

    /// <summary>
    /// The name of the device asset.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The status of the device asset.
    /// </summary>
    public string Status { get; set; } = string.Empty;
}