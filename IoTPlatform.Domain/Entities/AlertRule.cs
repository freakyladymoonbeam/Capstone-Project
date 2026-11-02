using IoTPlatform.Domain.Exceptions;

namespace IoTPlatform.Domain.Entities;

/// <summary>
/// This class represents an alert rule for a device asset within the IoT platform.
/// It stores the rule's name and the acceptable value range, and enforces business
/// rules related to the value range.
/// </summary>
public class AlertRule
{
    /// <summary>
    /// Unique identifier for the alert rule.
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// Identifier of the device asset associated with this alert rule.
    /// </summary>
    public Guid DeviceAssetId { get; private set; }

    /// <summary>
    /// Name of the alert rule.
    /// </summary>
    public string RuleName { get; private set; }

    /// <summary>
    /// Minimum value of the acceptable range for the alert rule.
    /// </summary>
    public double MinValue { get; private set; }

    /// <summary>
    /// Maximum value of the acceptable range for the alert rule.
    /// </summary>
    public double MaxValue { get; private set; }

    /// <summary>
    /// Initializes a new instance of the AlertRule class with the specified device asset ID,
    /// rule name, and value range.
    /// </summary>
    /// <param name="deviceAssetId">The ID of the device asset associated with this alert rule.</param>
    /// <param name="ruleName">The name of the alert rule.</param>
    /// <param name="minValue">The minimum value of the acceptable range.</param>
    /// <param name="maxValue">The maximum value of the acceptable range.</param>
    public AlertRule(
        Guid deviceAssetId,
        string ruleName,
        double minValue,
        double maxValue)
    {
        // Validate the specified value range before assigning properties.
        ValidateRange(minValue, maxValue);
        
        Id = Guid.NewGuid();
        DeviceAssetId = deviceAssetId;
        RuleName = ruleName;
        MinValue = minValue;
        MaxValue = maxValue;
    }

    /// <summary>
    /// Validates the specified value range.
    /// Throws a DomainException if the range is invalid.
    /// </summary>
    /// <param name="minValue">The minimum value of the range.</param>
    /// <param name="maxValue">The maximum value of the range.</param>
    private void ValidateRange(
        double minValue, 
        double maxValue)
    {
        if (minValue < 0)
        {
            throw new DomainException("Minimum value must be positive.");
        }

        if (maxValue < 0)
        {
            throw new DomainException("Maximum value must be positive.");
        }

        if (minValue >= maxValue)
        {
            throw new DomainException("Minimum value must be less than maximum value.");
        }
    }

    /// <summary>
    /// Gets the device asset associated with this alert rule.
    /// </summary>
    public DeviceAsset? DeviceAsset { get; private set; }
}