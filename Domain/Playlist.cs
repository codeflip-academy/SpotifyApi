namespace SpotifyApi;

public class Playlist
{
    public int PlaylistId { get; set; }
    public int UserId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime DateCreated { get; set; }
}
