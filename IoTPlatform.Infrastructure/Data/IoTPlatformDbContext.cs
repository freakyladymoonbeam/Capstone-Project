using Microsoft.EntityFrameworkCore;
using IoTPlatform.Domain.Entities;

namespace IoTPlatform.Infrastructure.Data;

/// <summary>
/// This class represents the Entity Framework Core database context for the IoT platform.
/// </summary>
public class IoTPlatformDbContext : DbContext
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IoTPlatformDbContext"/> class.
    /// </summary>
    /// <param name="options">The options to be used by the DbContext.</param>
    public IoTPlatformDbContext(DbContextOptions<IoTPlatformDbContext> options)
        : base(options)
    {
    }

    /// <summary>
    /// Gets the DbSet of device assets.
    /// </summary>
    public DbSet<DeviceAsset> DeviceAssets => Set<DeviceAsset>();
    
    /// <summary>
    /// Gets the DbSet of telemetry metrics.
    /// </summary>
    public DbSet<TelemetryMetric> TelemetryMetrics => Set<TelemetryMetric>();
    
    /// <summary>
    /// Gets the DbSet of alert rules.
    /// </summary>
    public DbSet<AlertRule> AlertRules => Set<AlertRule>();
    
    /// <summary>
    /// Gets the DbSet of maintenance logs.
    /// </summary>
    public DbSet<MaintenanceLog> MaintenanceLogs => Set<MaintenanceLog>();

    /// <summary>
    /// Configures the model for the IoT platform database context.
    /// </summary>
    /// <param name="modelBuilder">The model builder used to configure the entity framework model.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(IoTPlatformDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}