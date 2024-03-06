using Microsoft.AspNetCore.Mvc;

namespace SpotifyApi.Application.Commands;

public sealed class AddTrackCommand : HttpEndpoint
{
    [HttpPost("tracks")]
    public Task ExecuteAsync(
        [FromServices] ITrackRepository trackRepository,
        [FromBody] Track track)
    {
        throw new NotImplementedException();
    }
}