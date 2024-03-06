namespace SpotifyApi;

public interface IPlaylistRepository
{
    Task<List<Playlist>> FindAllAsync();
    Task<Playlist?> FindByIdAsync(int playlistId);
    Task AddAsync(Playlist playlist);
    Task UpdateAsync(Playlist playlist);
    Task DeleteAsync(int playlistId);
}
