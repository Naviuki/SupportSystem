using TicketModule.Services;

var builder = WebApplication.CreateBuilder(args);

// ✅ CORS для веб-сайта
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowWebApp", policy =>
    {
        policy.WithOrigins("http://localhost:5002")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddControllers();
builder.Services.AddSingleton<TicketService>();
builder.Services.AddHttpClient<NotificationClient>();

var app = builder.Build();

app.UseCors("AllowWebApp"); // ✅ Важно!
app.MapControllers();

Console.WriteLine("TicketModule API - http://localhost:5000");
app.Run("http://localhost:5000");
