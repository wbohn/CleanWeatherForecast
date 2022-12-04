using CleanWeatherForecast.Application;
using CleanWeatherForecast.Infrastructure;
using CleanWeatherForecast.Infrastructure.Database;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "DogEar", Version = "v1" });
    options.CustomSchemaIds(type => type.Name.EndsWith("Dto") ? type.Name.Replace("Dto", string.Empty) : type.Name);
});

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var scopedProvider = scope.ServiceProvider;
    var dbContext = scopedProvider.GetRequiredService<ApplicationDbContext>();
    await ApplicationDbContextSeed.SeedAsync(dbContext);
}

app.Run();
