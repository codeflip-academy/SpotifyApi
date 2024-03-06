using Microsoft.AspNetCore.Mvc;

namespace SpotifyApi.Application.Commands;

public sealed class DeleteAlbumCommand : HttpEndpoint
{
    [HttpDelete("albums/{id}")]
    public Task ExecuteAsync(
        [FromServices] IAlbumRepository albumRepository,
        [FromRoute] int id)
    {
        throw new NotImplementedException();
    }
}