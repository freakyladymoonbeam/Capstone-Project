namespace IoTPlatform.Application.DTOs;

/// <summary>
/// This class represents a Data Transfer Object (DTO) for a maintenance
/// log, containing its basic properties.
/// </summary>
public class MaintenanceLogDto
{
    /// <summary>
    /// The unique identifier of the maintenance log.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The unique identifier of the associated device asset.
    /// </summary>
    public Guid DeviceAssetId { get; set; }

    /// <summary>
    /// The date of the maintenance.
    /// </summary>
    public DateTime MaintenanceDate { get; set; }

    /// <summary>
    /// The name of the technician who performed the maintenance.
    /// </summary>
    public string Technician { get; set; } = string.Empty;

    /// <summary>
    /// Additional notes regarding the maintenance.
    /// </summary>
    public string Notes { get; set; } = string.Empty;
}