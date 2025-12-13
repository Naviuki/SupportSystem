using NotificationModule.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<NotificationService>();

var app = builder.Build();

app.MapControllers();

Console.WriteLine("NotificationModule API - http://localhost:5001");

app.Run("http://localhost:5001");
