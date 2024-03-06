using Microsoft.AspNetCore.Mvc;

namespace SpotifyApi.Application.Queries;

/// <summary>
/// Represents a query to retrieve a list of tracks.
/// </summary>
public sealed class GetTracksQuery : HttpEndpoint
{
    /// <summary>
    /// Executes the query asynchronously and returns a list of tracks.
    /// </summary>
    /// <returns>A task representing the asynchronous operation. The task result contains a list of tracks.</returns>
    [HttpGet("tracks")]
    public Task<List<Track>> ExecuteAsync(
        [FromServices] ITrackRepository trackRepository)
    {
        throw new NotImplementedException();
    }
}