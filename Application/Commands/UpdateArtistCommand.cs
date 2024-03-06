using Microsoft.AspNetCore.Mvc;

namespace SpotifyApi.Application.Commands;

public sealed class UpdateArtistCommand : HttpEndpoint
{
    [HttpPut("artists/{id}")]
    public Task ExecuteAsync(
        [FromServices] IArtistRepository artistRepository,
        [FromRoute] int id,
        [FromBody] Artist artist)
    {
        throw new NotImplementedException();
    }
}