using Microsoft.AspNetCore.Mvc;

namespace SpotifyApi.Application.Commands;

public sealed class DeleteUserCommand : HttpEndpoint
{
    [HttpDelete("users/{id}")]
    public Task ExecuteAsync(
        [FromServices] IUserRepository userRepository,
        [FromRoute] int id)
    {
        throw new NotImplementedException();
    }
}