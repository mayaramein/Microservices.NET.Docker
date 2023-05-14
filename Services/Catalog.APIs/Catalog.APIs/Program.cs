#region DI
using Catalog.APIs.Data;
using Catalog.APIs.Repository;
using Catalog.APIs.Shared;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddSwaggerGen(c => c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
{
    Title = "Catalog.APIs",
    Version = "v1",
}));

builder.Services.Configure<DatabaseSettings>(option => builder.Configuration.GetSection("DatabaseSettings").Bind(option));

builder.Services.AddSingleton<ICatalogContext, CatalogContext>();
builder.Services.AddScoped<IProductRepo, ProductRepo>(); 

#endregion

#region Middelware

var app = builder.Build();

// Configure the HTTP request pipeline.
var Env = app.Environment;

app.UseAuthorization();

app.MapControllers();

app.Run();

#endregion


