using Microsoft.AspNetCore.Mvc;

namespace SpotifyApi.Application.Commands;

public sealed class UpdateAlbumCommand : HttpEndpoint
{
    [HttpPut("albums/{id}")]
    public Task ExecuteAsync(
        [FromServices] IAlbumRepository albumRepository,
        [FromRoute] int id,
        [FromBody] Album album)
    {
        throw new NotImplementedException();
    }
}