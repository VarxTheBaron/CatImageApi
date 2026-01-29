using Microsoft.EntityFrameworkCore;
using CatImageApi.Data;
using CatImageApi.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Lägg till den DbContext ni skapar för er databas här
// builder.Services.AddDbContext<ApiDbContext>(options =>
//    options.UseInMemoryDatabase("EventDb"));

builder.Services.AddDbContext<CatDbContext>(options =>
    options.UseSqlite("Data Source=cats.db"));

//Controller service
builder.Services.AddControllers();

//Låt detta vara kvar! Utan denna inställning kommer inte websidan att få access till API:et.
// Läs mer här: https://developer.mozilla.org/en-US/docs/Web/HTTP/Guides/CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});


var app = builder.Build();

using var scope = app.Services.CreateScope();
var db = scope.ServiceProvider.GetRequiredService<CatDbContext>();
db.SetUpDatabase();

// Denna hör ihop med CORS-inställningen ovan
app.UseCors();

//Ni ska inte skriva era endpoints här i Program.cs utan i separata controllers, så använd denna:
app.MapControllers();

app.Run();
