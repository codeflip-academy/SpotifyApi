using Microsoft.AspNetCore.Mvc;

namespace SpotifyApi.Application.Commands;

public sealed class AddAlbumCommand : HttpEndpoint
{
    [HttpPost("albums")]
    public Task ExecuteAsync(
        [FromServices] IAlbumRepository albumRepository,
        [FromBody] Album album)
    {
        throw new NotImplementedException();
    }
}