using SpotifyApi.Application;

namespace SpotifyApi.Infrastructure;

public sealed class SqlClientPlaylistRepository : IPlaylistRepository
{
    private readonly DatabaseOptions _databaseOptions;

    public SqlClientPlaylistRepository(DatabaseOptions databaseOptions)
    {
        _databaseOptions = databaseOptions;
    }

    public Task AddAsync(Playlist playlist)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int playlistId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Playlist>> FindAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Playlist?> FindByIdAsync(int playlistId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Playlist playlist)
    {
        throw new NotImplementedException();
    }
}
