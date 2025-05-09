using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // INJECT DEPS ACROSS ALL APP
        services.AddSingleton<ConfigurationService>();
        return services;
    }
}