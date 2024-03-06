using Microsoft.AspNetCore.Mvc;

namespace SpotifyApi.Application.Queries;

/// <summary>
/// Represents a query to get a list of playlists.
/// </summary>
public sealed class GetPlaylistsQuery : HttpEndpoint
{
    /// <summary>
    /// Executes the query asynchronously and returns a list of playlists.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of playlists.</returns>
    [HttpGet("playlists")]
    public Task<List<Playlist>> ExecuteAsync(
        [FromServices] IPlaylistRepository playlistRepository)
    {
        throw new NotImplementedException();
    }
}