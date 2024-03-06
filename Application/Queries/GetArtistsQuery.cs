
using Microsoft.AspNetCore.Mvc;

namespace SpotifyApi.Application.Queries;

/// <summary>
/// Represents a query to get a list of artists.
/// </summary>
public sealed class GetArtistsQuery : HttpEndpoint
{
    /// <summary>
    /// Executes the GetArtistsQuery asynchronously.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of artists.</returns>
    [HttpGet("artists")]
    public Task<List<Artist>> ExecuteAsync(
        [FromServices] IArtistRepository artistRepository)
    {
        throw new NotImplementedException();
    }
}
