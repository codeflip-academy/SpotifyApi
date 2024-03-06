using Microsoft.AspNetCore.Mvc;

namespace SpotifyApi.Application.Commands;

public sealed class UpdatePlaylistCommand : HttpEndpoint
{
    [HttpPut("playlists/{id}")]
    public Task ExecuteAsync(
        [FromServices] IPlaylistRepository playlistRepository,
        [FromRoute] int id,
        [FromBody] Playlist playlist)
    {
        throw new NotImplementedException();
    }
}