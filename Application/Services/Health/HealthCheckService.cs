using Application.Exceptions.Health;
namespace Application.Services.Health;

public class HealthCheckService
{
    public async Task CheckHealth()
    {
        // Testing server health
        SentrySdk.CaptureMessage("Ocorreu um bug critico no sistema!");
        throw new ServerIsNotHealthException();
    }
}