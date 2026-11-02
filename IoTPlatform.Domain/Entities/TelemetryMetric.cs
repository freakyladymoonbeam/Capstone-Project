namespace IoTPlatform.Domain.Entities;

/// <summary>
/// This class represents a telemetry metric for a device asset within the IoT platform.
/// It stores the metric's name, value, and the timestamp when it was recorded.
/// A telemetry metric is a single recorded measurement for a specific device asset at a given point in time.
/// </summary>
public class TelemetryMetric
{
    /// <summary>
    /// Unique identifier for the telemetry metric.
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// Identifier of the device asset associated with this telemetry metric.
    /// </summary>
    public Guid DeviceAssetId { get; private set; }

    /// <summary>
    /// Name of the telemetry metric.
    /// </summary>
    public string MetricName { get; private set; }

    /// <summary>
    /// Value of the telemetry metric.
    /// </summary>
    public double Value { get; private set; }

    /// <summary>
    /// Timestamp when the telemetry metric was recorded.
    /// </summary>
    public DateTime Timestamp { get; private set; }

    /// <summary>
    /// Initializes a new instance of the TelemetryMetric class with the specified device asset ID,
    /// metric name, and value.
    /// </summary>
    /// <param name="deviceAssetId">The ID of the device asset associated with this telemetry metric.</param>
    /// <param name="metricName">The name of the telemetry metric.</param>
    /// <param name="value">The value of the telemetry metric.</param>`
    public TelemetryMetric(
        Guid deviceAssetId,
        string metricName,
        double value)
    {
        Id = Guid.NewGuid();
        DeviceAssetId = deviceAssetId;
        MetricName = metricName;
        Value = value;
        Timestamp = DateTime.UtcNow;
    }
}