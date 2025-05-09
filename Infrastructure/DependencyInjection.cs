using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddApplications(this IServiceCollection services)
    {
        // INJECT DEPS ACROSS ALL APP
        services.AddSingleton<ConfigurationService>();
        return services;
    }
}