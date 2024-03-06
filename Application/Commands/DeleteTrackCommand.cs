using Microsoft.AspNetCore.Mvc;

namespace SpotifyApi.Application.Commands;

public sealed class DeleteTrackCommand : HttpEndpoint
{
    [HttpDelete("tracks/{id}")]
    public Task ExecuteAsync(
        [FromServices] ITrackRepository trackRepository,
        [FromRoute] int id)
    {
        throw new NotImplementedException();
    }
}