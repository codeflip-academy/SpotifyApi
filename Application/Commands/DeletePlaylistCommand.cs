using Microsoft.AspNetCore.Mvc;

namespace SpotifyApi.Application.Commands;

public sealed class DeletePlaylistCommand : HttpEndpoint
{
    [HttpDelete("playlists/{id}")]
    public Task ExecuteAsync(
        [FromServices] IPlaylistRepository playlistRepository,
        [FromRoute] int id)
    {
        throw new NotImplementedException();
    }
}