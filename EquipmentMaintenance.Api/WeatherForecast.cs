namespace EquipmentMaintenance.Api;

public class WeatherForecast
{
    // 只有日期
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    // ?代表值可以是null
    public string? Summary { get; set; }
}
