namespace IoTPlatform.Domain.Entities;

/// <summary>
/// This class represents a maintenance log for a device asset within the IoT platform.
/// It stores information about the maintenance date, technician, and notes.
/// </summary>
public class MaintenanceLog
{
    /// <summary>
    /// Unique identifier for the maintenance log.
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// Identifier of the device asset associated with this maintenance log.
    /// </summary>
    public Guid DeviceAssetId { get; private set; }

    /// <summary>
    /// Date of the maintenance.
    /// </summary>
    public DateTime MaintenanceDate { get; private set; }

    /// <summary>
    /// Name of the technician who performed the maintenance.
    /// </summary>
    public string Technician { get; private set; }

    /// <summary>
    /// Notes related to the maintenance.
    /// </summary>
    public string Notes { get; private set; }

    /// <summary>
    /// Initializes a new instance of the MaintenanceLog class with the specified device asset ID,
    /// maintenance date, technician, and notes.
    /// </summary>
    /// <param name="deviceAssetId">The ID of the device asset associated with this maintenance log.</param>
    /// <param name="maintenanceDate">The date of the maintenance.</param>
    /// <param name="technician">The name of the technician who performed the maintenance.</param>
    /// <param name="notes">Notes related to the maintenance.</param>
    public MaintenanceLog(
        Guid deviceAssetId,
        DateTime maintenanceDate,
        string technician,
        string notes)
    {
        Id = Guid.NewGuid();
        DeviceAssetId = deviceAssetId;
        MaintenanceDate = maintenanceDate;
        Technician = technician;
        Notes = notes;
    }

    /// <summary>
    /// Gets the device asset associated with this maintenance log.
    /// </summary>
    public DeviceAsset? DeviceAsset { get; private set; }
}