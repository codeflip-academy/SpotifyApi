using Microsoft.AspNetCore.Mvc;

namespace SpotifyApi.Application.Commands;

public sealed class UpdateUserCommand : HttpEndpoint
{
    [HttpPut("users/{id}")]
    public Task ExecuteAsync(
        [FromServices] IUserRepository userRepository,
        [FromRoute] int id,
        [FromBody] User user)
    {
        throw new NotImplementedException();
    }
}