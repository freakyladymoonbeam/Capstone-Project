using Microsoft.EntityFrameworkCore;
using IoTPlatform.Application.Interfaces;
using IoTPlatform.Domain.Entities;
using IoTPlatform.Infrastructure.Data;

namespace IoTPlatform.Infrastructure.Repositories;

/// <summary>
/// This is the repository class for managing MaintenanceLog entities.
/// It provides methods for CRUD operations on MaintenanceLog entities.
/// </summary>
public class MaintenanceLogRepository : IMaintenanceLogRepository
{
    /// <summary>
    /// The database context for accessing MaintenanceLog entities.
    /// </summary>
    private readonly IoTPlatformDbContext _context;

    /// <summary>
    /// Initializes a new instance of the MaintenanceLogRepository class with the specified database context.
    /// </summary>
    /// <param name="context">The database context for accessing MaintenanceLog entities.</param>
    public MaintenanceLogRepository(IoTPlatformDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Gets a MaintenanceLog entity by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the MaintenanceLog entity.</param>
    /// <returns>The MaintenanceLog entity if found; otherwise, null.</returns>
    public async Task<MaintenanceLog?> GetByIdAsync(Guid id)
    {
        return await _context.MaintenanceLogs.FindAsync(id);
    }

    /// <summary>
    /// Gets all MaintenanceLog entities.
    /// </summary>
    /// <returns>A collection of all MaintenanceLog entities.</returns>
    public async Task<IEnumerable<MaintenanceLog>> GetAllAsync()
    {
        return await _context.MaintenanceLogs.ToListAsync();
    }

    /// <summary>
    /// Adds a new MaintenanceLog entity to the database.
    /// </summary>
    /// <param name="log">The MaintenanceLog entity to add.</param>
    public async Task AddAsync(MaintenanceLog log)
    {
        await _context.MaintenanceLogs.AddAsync(log);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Updates an existing MaintenanceLog entity in the database.
    /// </summary>
    /// <param name="log">The MaintenanceLog entity to update.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public async Task UpdateAsync(MaintenanceLog log)
    {
        _context.MaintenanceLogs.Update(log);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Deletes a MaintenanceLog entity by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the MaintenanceLog entity to delete.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public async Task DeleteAsync(Guid id)
    {
        var log = await GetByIdAsync(id);

        if (log != null)
        {
            _context.MaintenanceLogs.Remove(log);
            await _context.SaveChangesAsync();
        }
    }
}