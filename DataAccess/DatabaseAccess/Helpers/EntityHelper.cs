using Microsoft.EntityFrameworkCore;

namespace DataAccess.DatabaseAccess.Helpers;

public class EntityHelper(DbContext context)
{
    public Type? GetEntityTypeByTableName(string tableName)
    {
        // Get the model metadata
        var model = context.Model;

        // Iterate over the entity types in the model
        foreach (var entityType in model.GetEntityTypes())
        {
            // Get the table mapping for the current entity type
            var table = entityType.GetTableName();

            // Compare with the given table name (case-insensitive comparison)
            if (string.Equals(table, tableName, StringComparison.OrdinalIgnoreCase))
            {
                // Return the CLR type associated with the entity
                return entityType.ClrType;
            }
        }

        // Return null if no matching entity type was found
        return null;
    }
}