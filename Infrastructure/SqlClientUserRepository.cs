using SpotifyApi.Application;

namespace SpotifyApi.Infrastructure;

public sealed class SqlClientUserRepository : IUserRepository
{
    private readonly DatabaseOptions _databaseOptions;

    public SqlClientUserRepository(DatabaseOptions databaseOptions)
    {
        _databaseOptions = databaseOptions;
    }

    public Task AddAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<List<User>> FindAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<User?> FindByEmailAsync(string email)
    {
        throw new NotImplementedException();
    }

    public Task<User?> FindByIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<User?> FindByUsernameAsync(string username)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(User user)
    {
        throw new NotImplementedException();
    }
}
