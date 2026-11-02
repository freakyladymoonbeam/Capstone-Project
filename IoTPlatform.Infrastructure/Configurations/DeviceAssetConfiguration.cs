using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IoTPlatform.Domain.Entities;

namespace IoTPlatform.Infrastructure.Configurations;

/// <summary>
/// This class configures the DeviceAsset entity for Entity Framework Core. 
/// It specifies the primary key, required properties, and unique constraints.
/// </summary>
public class DeviceAssetConfiguration : IEntityTypeConfiguration<DeviceAsset>
{
    public void Configure(EntityTypeBuilder<DeviceAsset> builder)
    {
        // Configure the primary key for the DeviceAsset entity
        builder.HasKey(d => d.Id);

        // Configure the SerialNumber property with required and max length constraints.
        builder.Property(d => d.SerialNumber)
               .IsRequired()
               .HasMaxLength(20);
        
        // Configure a unique index on the SerialNumber property.
        builder.HasIndex(d => d.SerialNumber)
               .IsUnique();
        
        // Configure the Name property with required and max length constraints.
        builder.Property(d => d.Name)
               .IsRequired()
               .HasMaxLength(100);

        // Configure the Status property as required.
        builder.Property(d => d.Status)
               .IsRequired();
    }
}