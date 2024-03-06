namespace SpotifyApi;

public interface IArtistRepository
{
    Task<List<Artist>> FindAllAsync();
    Task<Artist?> FindByIdAsync(int artistId);
    Task AddAsync(Artist artist);
    Task UpdateAsync(Artist artist);
    Task DeleteAsync(int artistId);
}
