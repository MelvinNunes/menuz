using Application.Exceptions.Health;

namespace Application.Services.Health;

public class HealthCheckService
{
    public async Task CheckHealth()
    {
        // Testing server health
        throw new ServerIsNotHealthException();
    }
}