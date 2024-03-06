using Microsoft.AspNetCore.Mvc;

namespace SpotifyApi.Application.Commands;

public sealed class UpdateTrackCommand : HttpEndpoint
{
    [HttpPut("tracks/{id}")]
    public Task ExecuteAsync(
        [FromServices] ITrackRepository trackRepository,
        [FromRoute] int id,
        [FromBody] Track track)
    {
        throw new NotImplementedException();
    }
}