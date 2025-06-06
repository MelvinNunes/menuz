using Application.Services;
using Application.Services.Configuration;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<MenuzDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        return services;
    }
}