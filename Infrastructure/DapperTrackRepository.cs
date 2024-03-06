using SpotifyApi.Application;

namespace SpotifyApi.Infrastructure;

public sealed class DapperTrackRepository : ITrackRepository
{
    private readonly DatabaseOptions _databaseOptions;

    public DapperTrackRepository(DatabaseOptions databaseOptions)
    {
        _databaseOptions = databaseOptions;
    }

    public Task AddAsync(Track track)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int trackId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Track>> FindAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<Track>> FindByAlbumIdAsync(int albumId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Track>> FindByArtistIdAsync(int artistId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Track>> FindByGenreAsync(string genre)
    {
        throw new NotImplementedException();
    }

    public Task<Track?> FindByIdAsync(int trackId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Track>> FindByPlaylistIdAsync(int playlistId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Track>> FindByTitleAsync(string title)
    {
        throw new NotImplementedException();
    }

    public Task<List<Track>> FindByUserIdAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Track track)
    {
        throw new NotImplementedException();
    }
}
