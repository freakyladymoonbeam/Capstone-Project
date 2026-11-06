using Microsoft.EntityFrameworkCore;
using IoTPlatform.Application.Interfaces;
using IoTPlatform.Domain.Entities;
using IoTPlatform.Infrastructure.Data;

namespace IoTPlatform.Infrastructure.Repositories;

/// <summary>
/// This is the repository class for managing TelemetryMetric entities.
/// It provides methods for CRUD operations on TelemetryMetric entities.
/// </summary>
public class TelemetryMetricRepository : ITelemetryMetricRepository
{
    /// <summary>
    /// The database context for accessing TelemetryMetric entities.
    /// </summary>
    private readonly IoTPlatformDbContext _context;

    /// <summary>
    /// Initializes a new instance of the TelemetryMetricRepository class with the specified database context.
    /// </summary>
    /// <param name="context">The database context for accessing TelemetryMetric entities.</param>
    public TelemetryMetricRepository(IoTPlatformDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Gets a TelemetryMetric entity by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the TelemetryMetric entity.</param>
    /// <returns>The TelemetryMetric entity if found; otherwise, null.</returns>
    public async Task<TelemetryMetric?> GetByIdAsync(Guid id)
    {
        return await _context.TelemetryMetrics.FindAsync(id);
    }

    /// <summary>
    /// Gets all TelemetryMetric entities.
    /// </summary>
    /// <returns>A collection of all TelemetryMetric entities.</returns>
    public async Task<IEnumerable<TelemetryMetric>> GetAllAsync()
    {
        return await _context.TelemetryMetrics.ToListAsync();
    }

    /// <summary>
    /// Adds a new TelemetryMetric entity to the database.
    /// </summary>
    /// <param name="metric">The TelemetryMetric entity to add.</param>
    public async Task AddAsync(TelemetryMetric metric)
    {
        await _context.TelemetryMetrics.AddAsync(metric);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Updates an existing TelemetryMetric entity in the database.
    /// </summary>
    /// <param name="metric">The TelemetryMetric entity to update.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public async Task UpdateAsync(TelemetryMetric metric)
    {
        _context.TelemetryMetrics.Update(metric);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Deletes a TelemetryMetric entity by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the TelemetryMetric entity to delete.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public async Task DeleteAsync(Guid id)
    {
        var metric = await GetByIdAsync(id);

        if (metric != null)
        {
            _context.TelemetryMetrics.Remove(metric);
            await _context.SaveChangesAsync();
        }
    }
}