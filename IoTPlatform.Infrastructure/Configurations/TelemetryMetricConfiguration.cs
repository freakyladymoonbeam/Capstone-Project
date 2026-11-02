using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IoTPlatform.Domain.Entities;

namespace IoTPlatform.Infrastructure.Configurations;

/// <summary>
/// This class configures the TelemetryMetric entity for Entity Framework Core. 
/// It specifies the primary key, required properties, and relationships with other entities.
/// </summary>
public class TelemetryMetricConfiguration : IEntityTypeConfiguration<TelemetryMetric>
{
    public void Configure(EntityTypeBuilder<TelemetryMetric> builder)
    {
        // Configure the primary key for the TelemetryMetric entity
        builder.HasKey(t => t.Id);

        // Configure the MetricName property as required with a maximum length of 50
        builder.Property(t => t.MetricName)
               .IsRequired()
               .HasMaxLength(50);

        // Configure the relationship between TelemetryMetric and DeviceAsset as a one-to-many relationship
        builder.HasOne(t => t.DeviceAsset)
               .WithMany(d => d.TelemetryMetrics)
               .HasForeignKey(t => t.DeviceAssetId);
    }
}