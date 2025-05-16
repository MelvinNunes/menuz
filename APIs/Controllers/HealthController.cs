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

    public HealthController(HealthCheckService healthService)
    {
        _healthService = healthService;
    }
        
    [HttpGet]
    public async Task<ActionResult<ApiResponse<string>>> Health()
    {
        await _healthService.CheckHealth();
        return Ok(new ApiResponse<string>
            {
                Message = "The health check service is running.",
                StatusCode = 200,
                Data = ""
            });
    }
}