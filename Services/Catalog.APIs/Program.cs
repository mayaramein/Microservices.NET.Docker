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

builder.Services.AddScoped<ICatalogContext, CatalogContext>();
builder.Services.AddScoped<IProductRepo, ProductRepo>(); 

#endregion

#region Middelware

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

#endregion


