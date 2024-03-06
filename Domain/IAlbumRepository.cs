namespace SpotifyApi;

public interface IAlbumRepository
{
    Task<List<Album>> FindAllAsync();
    Task AddAsync(Album album);
    Task<Album?> FindByIdAsync(int albumId);
    Task UpdateAsync(Album album);
    Task DeleteAsync(int albumId);
}
