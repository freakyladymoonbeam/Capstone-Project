using IoTPlatform.Domain.Entities;

namespace IoTPlatform.Application.Interfaces;

/// <summary>
/// This is the repository interface for managing MaintenanceLog entities.
/// It provides methods for CRUD operations on MaintenanceLog entities.
/// </summary>
public interface IMaintenanceLogRepository
{
    /// <summary>
    /// Gets a MaintenanceLog by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the MaintenanceLog.</param>
    /// <returns>The MaintenanceLog if found; otherwise, null.</returns>
    Task<MaintenanceLog?> GetByIdAsync(Guid id);
    
    /// <summary>
    /// Gets all MaintenanceLog entities.
    /// </summary>
    /// <returns>A collection of all MaintenanceLog entities.</returns>
    Task<IEnumerable<MaintenanceLog>> GetAllAsync();
    
    /// <summary>
    /// Adds a new MaintenanceLog entity.
    /// </summary>
    /// <param name="log">The MaintenanceLog entity to add.</param>
    Task AddAsync(MaintenanceLog log);
    
    /// <summary>
    /// Updates an existing MaintenanceLog entity.
    /// </summary>
    /// <param name="log">The MaintenanceLog entity to update.</param>
    Task UpdateAsync(MaintenanceLog log);
    
    /// <summary>
    /// Deletes a MaintenanceLog entity by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the MaintenanceLog to delete.</param>
    /// <returns>A task representing the asynchronous delete operation.</returns>
    Task DeleteAsync(Guid id);
}