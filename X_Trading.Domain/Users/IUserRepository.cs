namespace X_Trading.Domain.Users;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllAsync();
    Task<User> GetAsync(Guid id);
    Task<User> GetAsync(string email);
    Task AddAsync(User user);
    void UpdateAsync(User user);
    void DeleteAsync(User user);
}
