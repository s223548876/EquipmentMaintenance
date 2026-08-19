using EquipmentMaintenance.Api.Services;

namespace EquipmentMaintenance.Api.Tests;

public class SystemStatusServiceTests
{
    [Fact]
    public void GetStatus_ReturnsApplicationStatus()
    {
        var service = new SystemStatusService();

        var status = service.GetStatus();

        Assert.Equal("Equipment Maintenance API", status.ApplicationName);
        Assert.Equal("OK", status.Status);
    }
}
