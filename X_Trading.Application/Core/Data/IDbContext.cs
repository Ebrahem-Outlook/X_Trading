using Microsoft.EntityFrameworkCore;
using X_Trading.Domain.Core;

namespace X_Trading.Application.Core.Data;

public interface IDbContext
{
    DbSet<TEntity> Set<TEntity>() where TEntity : Entity;
}
