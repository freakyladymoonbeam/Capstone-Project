namespace IoTPlatform.Domain.Entities;

public class MaintenanceLog
{
    public Guid Id { get; private set; }
    public Guid DeviceAssetId { get; private set; }
    public DateTime MaintenanceDate { get; private set; }
    public string Technician { get; private set; }
    public string Notes { get; private set; }

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
}