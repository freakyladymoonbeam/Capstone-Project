using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IoTPlatform.Domain.Entities;

namespace IoTPlatform.Infrastructure.Configurations;

/// <summary>
/// This class configures the AlertRule entity for Entity Framework Core.
/// It specifies the primary key, required properties, and relationships with other entities.
/// </summary>
public class AlertRuleConfiguration : IEntityTypeConfiguration<AlertRule>
{
    public void Configure(EntityTypeBuilder<AlertRule> builder)
    {
        // Configure the primary key for the AlertRule entity
        builder.HasKey(a => a.Id);

        // Configure the RuleName property as required with a maximum length of 100
        builder.Property(a => a.RuleName)
               .IsRequired()
               .HasMaxLength(100);

        // Configure the relationship between AlertRule and DeviceAsset as a one-to-many relationship
        builder.HasOne(a => a.DeviceAsset)
               .WithMany(d => d.AlertRules)
               .HasForeignKey(a => a.DeviceAssetId);
    }
}