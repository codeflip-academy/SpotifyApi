namespace SpotifyApi;

public interface IUserRepository
{
    Task AddAsync(User user);
    Task<List<User>> FindAllAsync();
    Task<User?> FindByIdAsync(int userId);
    Task<User?> FindByUsernameAsync(string username);
    Task<User?> FindByEmailAsync(string email);
    Task UpdateAsync(User user);
    Task DeleteAsync(int userId);
}
