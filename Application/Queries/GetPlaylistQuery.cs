using Microsoft.AspNetCore.Mvc;

namespace SpotifyApi.Application.Queries;

/// <summary>
/// Represents a query to get a playlist.
/// </summary>
public sealed class GetPlaylistQuery : HttpEndpoint
{
    /// <summary>
    /// Executes the query asynchronously.
    /// </summary>
    /// <returns>A task representing the asynchronous operation. The task result contains the playlist if successful; otherwise, null.</returns>
    [HttpGet("playlists/{playlistId}")]
    public Task<Playlist?> ExecuteAsync(
        [FromServices] IPlaylistRepository playlistRepository,
        [FromRoute] int playlistId
    )
    {
        throw new NotImplementedException();
    }
}