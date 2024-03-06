using Microsoft.AspNetCore.Mvc;

namespace SpotifyApi.Application.Queries;

/// <summary>
/// Represents a query to get a user.
/// </summary>
public sealed class GetUserQuery : HttpEndpoint
{
    /// <summary>
    /// Executes the query asynchronously.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains the user.</returns>
    [HttpGet("users/{userId}")]
    public Task<User?> ExecuteAsync(
        [FromServices] IUserRepository userRepository,
        [FromRoute] int userId)
    {
        throw new NotImplementedException();
    }
}