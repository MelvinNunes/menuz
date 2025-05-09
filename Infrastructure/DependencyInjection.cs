using Application.Services;
using Application.Services.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddApplications(this IServiceCollection services)
    {
        services.AddSingleton<IConfigService, ConfigurationService>();
        return services;
    }
}