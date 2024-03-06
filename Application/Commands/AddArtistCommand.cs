using Microsoft.AspNetCore.Mvc;

namespace SpotifyApi.Application.Commands;

public sealed class AddArtistCommand : HttpEndpoint
{
    [HttpPost("artists")]
    public Task ExecuteAsync(
        [FromServices] IArtistRepository artistRepository,
        [FromBody] Artist artist)
    {
        throw new NotImplementedException();
    }
}