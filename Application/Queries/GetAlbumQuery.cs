using Microsoft.AspNetCore.Mvc;

namespace SpotifyApi.Application.Queries;

/// <summary>
/// Represents a query to get an album.
/// </summary>
public sealed class GetAlbumQuery : HttpEndpoint
{
    /// <summary>
    /// Executes the query asynchronously.
    /// </summary>
    /// <returns>The album if found, otherwise null.</returns>
    [HttpGet("albums/{albumId}")]
    public Task<Album?> ExecuteAsync(
        [FromServices] IAlbumRepository albumRepository,
        [FromRoute] int albumId)
    {
        throw new NotImplementedException();
    }
}