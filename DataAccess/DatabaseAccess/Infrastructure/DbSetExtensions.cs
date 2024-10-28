using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DataAccess.DatabaseAccess.Infrastructure;

public static class DbSetExtensions
{
    public static EntityEntry<T>? AddIfNotExists<T>(this DbSet<T> dbSet, T entity, Expression<Func<T, bool>>? predicate = null) where T : class, new()
    {
        var exists = predicate != null ? dbSet.Any(predicate) : dbSet.Any();
        return !exists ? dbSet.Add(entity) : null;
    }
    
    public static EntityEntry<T> DeleteIfExistsAndInsert<T>(this DbSet<T> dbSet, T entity, Expression<Func<T, bool>> predicate) where T : class, new()
    {
        var existingEntity = dbSet.FirstOrDefault(predicate);

        if (existingEntity != null)
        {
            // Update the existing entity with the values from the new entity
            dbSet.Remove(existingEntity);
        }

        // If not found, add the new entity
        return dbSet.Add(entity);
    }
}