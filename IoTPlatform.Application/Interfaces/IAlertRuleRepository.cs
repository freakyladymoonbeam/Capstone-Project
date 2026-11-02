using IoTPlatform.Domain.Entities;

namespace IoTPlatform.Application.Interfaces;

/// <summary>
/// This is the repository interface for managing AlertRule entities.
/// It provides methods for CRUD operations on AlertRule entities.
/// </summary>
public interface IAlertRuleRepository
{
    /// <summary>
    /// Gets an AlertRule by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the AlertRule.</param>
    /// <returns>The AlertRule if found; otherwise, null.</returns>
    Task<AlertRule?> GetByIdAsync(Guid id);
    
    /// <summary>
    /// Gets all AlertRule entities.
    /// </summary>
    /// <returns>A collection of all AlertRule entities.</returns>
    Task<IEnumerable<AlertRule>> GetAllAsync();
    
    /// <summary>
    /// Adds a new AlertRule entity.
    /// </summary>
    /// <param name="rule">The AlertRule entity to add.</param>
    Task AddAsync(AlertRule rule);
    
    /// <summary>
    /// Updates an existing AlertRule entity.
    /// </summary>
    /// <param name="rule">The AlertRule entity to update.</param>
    Task UpdateAsync(AlertRule rule);
    
    /// <summary>
    /// Deletes an AlertRule entity by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the AlertRule to delete.</param>
    /// <returns>A task representing the asynchronous delete operation.</returns>
    Task DeleteAsync(Guid id);
}