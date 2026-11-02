using IoTPlatform.Domain.Entities;

namespace IoTPlatform.Application.Interfaces;

/// <summary>
/// This is the repository interface for managing TelemetryMetric entities.
/// It provides methods for CRUD operations on TelemetryMetric entities.
/// </summary>
public interface ITelemetryMetricRepository
{
    /// <summary>
    /// Gets a TelemetryMetric by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the TelemetryMetric.</param>
    /// <returns>The TelemetryMetric if found; otherwise, null.</returns>
    Task<TelemetryMetric?> GetByIdAsync(Guid id);
    
    /// <summary>
    /// Gets all TelemetryMetric entities.
    /// </summary>
    /// <returns>A collection of all TelemetryMetric entities.</returns>
    Task<IEnumerable<TelemetryMetric>> GetAllAsync();
    
    /// <summary>
    /// Adds a new TelemetryMetric entity.
    /// </summary>
    /// <param name="metric">The TelemetryMetric entity to add.</param>
    Task AddAsync(TelemetryMetric metric);
    
    /// <summary>
    /// Updates an existing TelemetryMetric entity.
    /// </summary>
    /// <param name="metric">The TelemetryMetric entity to update.</param>
    Task UpdateAsync(TelemetryMetric metric);
    
    /// <summary>
    /// Deletes a TelemetryMetric entity by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the TelemetryMetric to delete.</param>
    /// <returns>A task representing the asynchronous delete operation.</returns>
    Task DeleteAsync(Guid id);
}