using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace IoTPlatform.Infrastructure.Data;

/// <summary>
/// This class is used to create an instance of IoTPlatformDbContext at design time, for 
/// example when running EF Core migrations.
/// Design time is when the application is not running, but tools like EF Core need to create 
/// an instance of the DbContext.
/// </summary>
public class IoTPlatformDbContextFactory : IDesignTimeDbContextFactory<IoTPlatformDbContext>
{
    public IoTPlatformDbContext CreateDbContext(string[] args)
    {
        // Create a new DbContextOptionsBuilder for IoTPlatformDbContext
        var optionsBuilder = new DbContextOptionsBuilder<IoTPlatformDbContext>();

        // Configure the DbContext to use SQL Server with the specified connection string
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=IoTPlatformDb;Trusted_Connection=True;");

        // Return a new instance of IoTPlatformDbContext with the configured options
        return new IoTPlatformDbContext(optionsBuilder.Options);
    }
}