using CleanArchitectureInfrastructure.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureInfrastructure;

public static class InfrastructureDependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            //options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
        });


        return services;
    }
}