using Docker.AspNetCore.Web.Data;
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

        return services;
    }
}
