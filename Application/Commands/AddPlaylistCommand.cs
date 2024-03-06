using Microsoft.AspNetCore.Mvc;

namespace SpotifyApi.Application.Commands;

public sealed class AddPlaylistCommand : HttpEndpoint
{
    [HttpPost("playlists")]
    public Task ExecuteAsync(
        [FromServices] IPlaylistRepository playlistRepository,
        [FromBody] Playlist playlist)
    {
        throw new NotImplementedException();
    }
}