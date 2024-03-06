using SpotifyApi.Application;

namespace SpotifyApi.Infrastructure;

public sealed class DapperArtistRepository : IArtistRepository
{
    private readonly DatabaseOptions _databaseOptions;

    public DapperArtistRepository(DatabaseOptions databaseOptions)
    {
        _databaseOptions = databaseOptions;
    }

    public Task AddAsync(Artist artist)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int artistId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Artist>> FindAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Artist?> FindByIdAsync(int artistId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Artist artist)
    {
        throw new NotImplementedException();
    }
}
