using System.Net;
using APIs.Response;
using Application.Services.Health;
using Microsoft.AspNetCore.Mvc;

namespace APIs.Controllers;

[ApiController]
[Route("/api/health")]
public class HealthController : ControllerBase
{
    private readonly HealthCheckService  _healthService;
    private readonly ILogger<HealthController> _logger;

    public HealthController(HealthCheckService healthService,  ILogger<HealthController> logger)
    {
        _healthService = healthService;
        _logger = logger;
    }
        
    [HttpGet]
    public async Task<ActionResult<ApiResponse<string>>> Health()
    {
        try
        {
            await _healthService.CheckHealth();
            return Ok(new ApiResponse<string>
            {
                Message = "The health check service is running.",
                StatusCode = 200,
                Data = ""
            });
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error handling health check service");
            throw;
        }
    }
}