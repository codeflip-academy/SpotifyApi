using SpotifyApi.Infrastructure;

namespace SpotifyApi.Application;

public static class InfrastructureServiceExtensions
{
    public static IServiceCollection AddSqlClientRepositories(this IServiceCollection services)
    {
        services.AddScoped<IAlbumRepository, SqlClientAlbumRepository>();
        services.AddScoped<IArtistRepository, SqlClientAristRepository>();
        services.AddScoped<IPlaylistRepository, SqlClientPlaylistRepository>();
        services.AddScoped<ITrackRepository, SqlClientTrackRepository>();
        services.AddScoped<IUserRepository, SqlClientUserRepository>();

        return services;
    }

    public static IServiceCollection AddDapperRepositories(this IServiceCollection services)
    {
        services.AddScoped<IAlbumRepository, DapperAlbumRepository>();
        services.AddScoped<IArtistRepository, DapperArtistRepository>();
        services.AddScoped<IPlaylistRepository, DapperPlaylistRepository>();
        services.AddScoped<ITrackRepository, DapperTrackRepository>();
        services.AddScoped<IUserRepository, DapperUserRepository>();

        return services;
    }
}
