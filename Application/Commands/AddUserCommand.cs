using Microsoft.AspNetCore.Mvc;

namespace SpotifyApi.Application.Commands;

public sealed class AddUserCommand : HttpEndpoint
{
    [HttpPost("users")]
    public Task ExecuteAsync(
        [FromServices] IUserRepository userRepository,
        [FromBody] User user)
    {
        throw new NotImplementedException();
    }
}