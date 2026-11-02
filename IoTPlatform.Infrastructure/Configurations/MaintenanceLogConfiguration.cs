using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IoTPlatform.Domain.Entities;

namespace IoTPlatform.Infrastructure.Configurations;

/// <summary>
/// This class configures the MaintenanceLog entity for Entity Framework Core.
/// It specifies the primary key, required properties, and relationships with other entities.
/// </summary>
public class MaintenanceLogConfiguration : IEntityTypeConfiguration<MaintenanceLog>
{
    public void Configure(EntityTypeBuilder<MaintenanceLog> builder)
    {
        // Configure the primary key for the MaintenanceLog entity
        builder.HasKey(m => m.Id);

        // Configure the Technician property as required with a maximum length of 100
        builder.Property(m => m.Technician)
               .IsRequired()
               .HasMaxLength(100);
               
        // Configure the relationship between MaintenanceLog and DeviceAsset as a one-to-many relationship
        builder.HasOne(m => m.DeviceAsset)
               .WithMany(d => d.MaintenanceLogs)
               .HasForeignKey(m => m.DeviceAssetId);
    }
}