namespace SpotifyApi;

public class Track
{
    public int TrackId { get; set; }
    public string? Title { get; set; }
    public int? AlbumId { get; set; }
    public int Duration { get; set; }
    public DateTime? ReleaseDate { get; set; }
}
