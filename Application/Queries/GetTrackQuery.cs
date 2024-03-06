using Microsoft.AspNetCore.Mvc;

namespace SpotifyApi.Application.Queries;

/// <summary>
/// Represents a query to retrieve a track.
/// </summary>
public sealed class GetTrackQuery : HttpEndpoint
{
    /// <summary>
    /// Executes the asynchronous operation to get a track.
    /// </summary>
    /// <returns>A task representing the asynchronous operation. The task result contains the track, or null if not found.</returns>
    [HttpGet("tracks/{trackId}")]
    public Task<Track?> ExecuteAsync(
        [FromServices] ITrackRepository trackRepository,
        [FromRoute] int trackId)
    {
        throw new NotImplementedException();
    }
}