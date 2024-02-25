using CleanArchitecture.Application.Services.UserProfileService;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Application;

public static class ApplicationDependencyInjection
{
    public static IServiceCollection AddAplication(this IServiceCollection services)
    {
        services.AddScoped<IUserProfileService, UserProfileService>();
        return services;
    }
}