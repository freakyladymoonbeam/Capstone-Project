namespace IoTPlatform.Application.DTOs;

/// <summary>
/// This class represents a Data Transfer Object (DTO) for a telemetry
/// metric, containing its basic properties.
/// </summary>
public class TelemetryMetricDto
{
    /// <summary>
    /// The unique identifier of the telemetry metric.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The unique identifier of the associated device asset.
    /// </summary>
    public Guid DeviceAssetId { get; set; }

    /// <summary>
    /// The name of the telemetry metric.
    /// </summary>
    public string MetricName { get; set; } = string.Empty;

    /// <summary>
    /// The value of the telemetry metric.
    /// </summary>
    public double Value { get; set; }

    /// <summary>
    /// The timestamp when the telemetry metric was recorded.
    /// </summary>
    public DateTime Timestamp { get; set; }
}