using Microsoft.EntityFrameworkCore;
using IoTPlatform.Application.Interfaces;
using IoTPlatform.Domain.Entities;
using IoTPlatform.Infrastructure.Data;

namespace IoTPlatform.Infrastructure.Repositories;

/// <summary>
/// This is the repository class for managing AlertRule entities.
/// It provides methods for CRUD operations on AlertRule entities.
/// </summary>
public class AlertRuleRepository : IAlertRuleRepository
{
    /// <summary>
    /// The database context for accessing AlertRule entities.
    /// </summary>
    private readonly IoTPlatformDbContext _context;

    /// <summary>
    /// Initializes a new instance of the AlertRuleRepository class with the specified database context.
    /// </summary>
    /// <param name="context">The database context for accessing AlertRule entities.</param>
    public AlertRuleRepository(IoTPlatformDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Gets an AlertRule entity by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the AlertRule entity.</param>
    /// <returns>The AlertRule entity if found; otherwise, null.</returns>
    public async Task<AlertRule?> GetByIdAsync(Guid id)
    {
        return await _context.AlertRules.FindAsync(id);
    }

    /// <summary>
    /// Gets all AlertRule entities.
    /// </summary>
    /// <returns>A collection of all AlertRule entities.</returns>
    public async Task<IEnumerable<AlertRule>> GetAllAsync()
    {
        return await _context.AlertRules.ToListAsync();
    }

    /// <summary>
    /// Adds a new AlertRule entity to the database.
    /// </summary>
    /// <param name="rule">The AlertRule entity to add.</param>
    public async Task AddAsync(AlertRule rule)
    {
        await _context.AlertRules.AddAsync(rule);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Updates an existing AlertRule entity in the database.
    /// </summary>
    /// <param name="rule">The AlertRule entity to update.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public async Task UpdateAsync(AlertRule rule)
    {
        _context.AlertRules.Update(rule);
        await _context.SaveChangesAsync();
    }
    /// <summary>
    /// Deletes an AlertRule entity by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the AlertRule entity to delete.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public async Task DeleteAsync(Guid id)
    {
        var rule = await GetByIdAsync(id);

        if (rule != null)
        {
            _context.AlertRules.Remove(rule);
            await _context.SaveChangesAsync();
        }
    }
}