using EquipmentMaintenance.Api.Services;

// 建立建造器，準備之後要用的設定與服務
var builder = WebApplication.CreateBuilder(args);

// 使用 Controllers 接收 HTTP Request
builder.Services.AddControllers();
builder.Services.AddScoped<SystemStatusService>();

// 系統要用 OpenAPI
builder.Services.AddOpenApi();

// 建立 Application
var app = builder.Build();

// 是否為開發環境
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// 若有人用 HTTP 連進來，導向 HTTPS
app.UseHttpsRedirection();

// 授權
app.UseAuthorization();

// 讓 Controller 的 Route 可以被 HTTP Request 找到
app.MapControllers();

app.Run();
