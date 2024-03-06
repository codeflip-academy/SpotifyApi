using Microsoft.AspNetCore.Mvc;

namespace SpotifyApi.Application.Queries;

/// <summary>
/// Represents a query to get a list of users.
/// </summary>
public sealed class GetUsersQuery : HttpEndpoint
{
    /// <summary>
    /// Executes the query asynchronously and returns a list of users.
    /// </summary>
    /// <returns>A task representing the asynchronous operation. The task result contains a list of users.</returns>
    [HttpGet("users")]
    public Task<List<User>> ExecuteAsync(
        [FromServices] IUserRepository userRepository)
    {
        throw new NotImplementedException();
    }
}