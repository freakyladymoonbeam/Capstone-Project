namespace IoTPlatform.Application.DTOs;

/// <summary>
/// This class represents a Data Transfer Object (DTO) for an alert
/// rule, containing its basic properties.
/// A Data Transfer Object is a simple object used to transfer data between 
/// layers or components of an application, without containing any business 
/// logic.
/// </summary>
public class AlertRuleDto
{
    /// <summary>
    /// The unique identifier of the alert rule.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The unique identifier of the associated device asset.
    /// </summary>
    public Guid DeviceAssetId { get; set; }

    /// <summary>
    /// The name of the alert rule.
    /// </summary>
    public string RuleName { get; set; } = string.Empty;

    /// <summary>
    /// The minimum value for the alert rule.
    /// </summary>
    public double MinimumValue { get; set; }

    /// <summary>
    /// The maximum value for the alert rule.
    /// </summary>
    public double MaximumValue { get; set; }
}