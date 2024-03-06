namespace SpotifyApi;

public interface ITrackRepository
{
    Task<List<Track>> FindAllAsync();
    Task<Track?> FindByIdAsync(int trackId);
    Task<List<Track>> FindByAlbumIdAsync(int albumId);
    Task<List<Track>> FindByPlaylistIdAsync(int playlistId);
    Task<List<Track>> FindByArtistIdAsync(int artistId);
    Task<List<Track>> FindByGenreAsync(string genre);
    Task<List<Track>> FindByTitleAsync(string title);
    Task<List<Track>> FindByUserIdAsync(int userId);
    Task AddAsync(Track track);
    Task UpdateAsync(Track track);
    Task DeleteAsync(int trackId);
}
