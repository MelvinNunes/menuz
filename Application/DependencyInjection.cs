using Application.Services.Configuration;
using Application.Services.Health;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplications(this IServiceCollection services)
    {
        services.AddSingleton<IConfigService, ConfigurationService>();
        services.AddSingleton<HealthCheckService>();
        return services;
    }
}