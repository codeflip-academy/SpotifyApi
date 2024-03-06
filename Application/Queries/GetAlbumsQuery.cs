using Microsoft.AspNetCore.Mvc;

namespace SpotifyApi.Application.Queries;

/// <summary>
/// Represents a query to retrieve a list of albums.
/// </summary>
public sealed class GetAlbumsQuery : HttpEndpoint
{
    /// <summary>
    /// Executes the query asynchronously and returns a list of albums.
    /// </summary>
    /// <returns>A task representing the asynchronous operation. The task result contains a list of albums.</returns>
    [HttpGet("albums")]
    public Task<List<Album>> ExecuteAsync(
        [FromServices] IAlbumRepository albumRepository)
    {
        throw new NotImplementedException();
    }
}