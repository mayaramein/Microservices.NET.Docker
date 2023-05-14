#region DI
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
#endregion

#region Middelware

var app = builder.Build();

// Configure the HTTP request pipeline.
var Env = app.Environment;

app.UseAuthorization();

app.MapControllers();

app.Run();

#endregion


