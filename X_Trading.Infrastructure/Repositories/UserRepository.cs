using Microsoft.EntityFrameworkCore;
using X_Trading.Application.Core.Data;
using X_Trading.Domain.Users;

namespace X_Trading.Infrastructure.Repositories;

internal sealed class UserRepository(IDbContext dbContext) : IUserRepository
{
    public async Task AddAsync(User user)
    {
        await dbContext.Set<User>().AddAsync(user); 
    }

    public void DeleteAsync(User user)
    {
        dbContext.Set<User>().Remove(user);
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        return await dbContext.Set<User>().ToListAsync();
    }

    public async Task<User?> GetAsync(Guid id)
    {
        return await dbContext.Set<User>().FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<User?> GetAsync(string email)
    {
        return await dbContext.Set<User>().FirstOrDefaultAsync(x => x.Email == email);  
    }

    public void UpdateAsync(User user)
    {
        dbContext.Set<User>().Update(user);
    }
}
