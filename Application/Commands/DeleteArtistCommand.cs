using Microsoft.AspNetCore.Mvc;

namespace SpotifyApi.Application.Commands;

public sealed class DeleteArtistCommand : HttpEndpoint
{
    [HttpDelete("artists/{id}")]
    public Task ExecuteAsync(
        [FromServices] IArtistRepository artistRepository,
        [FromRoute] int id)
    {
        throw new NotImplementedException();
    }
}