using System.Text.RegularExpressions;
using IoTPlatform.Domain.Enums;
using IoTPlatform.Domain.Exceptions;

namespace IoTPlatform.Domain.Entities;

/// <summary>
/// This class represents a device asset within the IoT platform. It stores identifying 
/// information and enforces business rules related to device status and serial number 
/// format.
/// </summary>
public class DeviceAsset
{
    /// <summary>
    /// Unique identifier for the device asset.
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// Serial number of the device asset, following the format DEV-12345.
    /// </summary>
    public string SerialNumber { get; private set; }

    /// <summary>
    /// Name of the device asset.
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Current status of the device asset.
    /// </summary>
    public DeviceStatus Status { get; private set; }

    /// <summary>
    /// Date when the device asset was installed.
    /// </summary>
    public DateTime InstalledDate { get; private set; }

    /// <summary>
    /// Initializes a new instance of the DeviceAsset class with the specified serial 
    /// number, name, and installation date.
    /// </summary>
    /// <param name="serialNumber">The serial number of the device asset.</param>
    /// <param name="name">The name of the device asset.</param>
    /// <param name="installedDate">The date when the device asset was installed.</param>
    public DeviceAsset(
        string serialNumber,
        string name,
        DateTime installedDate)
    {
        // Validate the format of the serial number.
        ValidateSerialNumber(serialNumber);
        
        Id = Guid.NewGuid();
        SerialNumber = serialNumber;
        Name = name;
        InstalledDate = installedDate;

        // New devices always start with the Registered status.
        Status = DeviceStatus.Registered;
    }

    /// <summary>
    /// Validates the format of the serial number.
    /// Throws a DomainException if the format is invalid.
    /// </summary>
    /// <param name="serialNumber">The serial number to validate.</param>
    private void ValidateSerialNumber(string serialNumber)
    {
        var pattern = @"^DEV-\d{5}$";

        if (!Regex.IsMatch(serialNumber, pattern))
        {
            throw new DomainException("Serial number must follow format DEV-12345");
        }
    }

    /// <summary>
    /// Changes the status of the device asset to the specified new status.
    /// Throws a DomainException if the status transition is invalid.
    /// </summary>
    /// <param name="newStatus">The new status to set for the device asset.</param>
    public void ChangeStatus(DeviceStatus newStatus)
    {
        bool validTransition = 
            (Status == DeviceStatus.Registered &&
             newStatus == DeviceStatus.Active)

            ||
        
            (Status == DeviceStatus.Active &&
             (newStatus == DeviceStatus.Maintenance ||
              newStatus == DeviceStatus.Retired))

            ||
        
            (Status == DeviceStatus.Maintenance &&
             (newStatus == DeviceStatus.Active ||
              newStatus == DeviceStatus.Retired));
    
        if (!validTransition)
        {
            throw new DomainException($"Invalid status transition from {Status} to {newStatus}");
        }

        Status = newStatus;
    }
}