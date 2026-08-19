using EquipmentMaintenance.Api.Dtos;

namespace EquipmentMaintenance.Api.Services;

public class SystemStatusService
{
    public SystemStatusResponse GetStatus()
    {
        return new SystemStatusResponse("Equipment Maintenance API", "OK");
    }
}
