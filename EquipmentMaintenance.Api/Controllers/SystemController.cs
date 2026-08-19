using EquipmentMaintenance.Api.Dtos;
using EquipmentMaintenance.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace EquipmentMaintenance.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SystemController : ControllerBase
{
    private readonly SystemStatusService _systemStatusService;

    public SystemController(SystemStatusService systemStatusService)
    {
        _systemStatusService = systemStatusService;
    }

    [HttpGet("status")]
    public ActionResult<SystemStatusResponse> GetStatus()
    {
        return Ok(_systemStatusService.GetStatus());
    }
}
