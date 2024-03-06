using Microsoft.AspNetCore.Mvc;

namespace SpotifyApi.Application.Queries;

/// <summary>
/// Represents a query to get an artist.
/// </summary>
public sealed class GetArtistQuery : HttpEndpoint
{
    /// <summary>
    /// Executes the query asynchronously.
    /// </summary>
    /// <returns>The artist if found, otherwise null.</returns>
    [HttpGet("artists/{artistId}")]
    public Task<Artist?> ExecuteAsync(
        [FromServices] IArtistRepository artistRepository,
        [FromRoute] int artistId)
    {
        throw new NotImplementedException();
    }
}
