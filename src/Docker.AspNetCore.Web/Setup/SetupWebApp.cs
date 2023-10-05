using Docker.AspNetCore.Web.Data;
using Docker.AspNetCore.Web.Data.Repositories;
using Docker.AspNetCore.Web.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Docker.AspNetCore.Web.Setup;

public static class SetupWebApp
{
    public static IServiceCollection AddWebApp(
        this IServiceCollection services)
    {
        var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseNpgsql(connectionString);
        });

        var redisConnectionString = Environment.GetEnvironmentVariable("REDIS_CONNECTION_STRING");
        services.AddStackExchangeRedisCache(opt =>
        {
            opt.Configuration = redisConnectionString;
        });

        services.AddScoped<BlogRepository>();
        services.AddScoped<IBlogRepository, BlogCachedRepository>();

        return services;
    }
}
