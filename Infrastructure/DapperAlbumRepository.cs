using SpotifyApi.Application;

namespace SpotifyApi.Infrastructure;

public sealed class DapperAlbumRepository : IAlbumRepository
{
    private readonly DatabaseOptions _databaseOptions;

    public DapperAlbumRepository(DatabaseOptions databaseOptions)
    {
        _databaseOptions = databaseOptions;
    }

    public Task AddAsync(Album album)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int albumId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Album>> FindAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Album?> FindByIdAsync(int albumId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Album album)
    {
        throw new NotImplementedException();
    }
}
