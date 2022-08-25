using VintageFootballShirts.Infrastructure.Mongo.Document;
using MediatR;
using VintageFootballShirts.Core.Repository;
using VintageFootballShirts.Infrastructure.Mongo.Repositories;
using System.Reflection;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.Configure<ShirtsDatabaseSettings>(
    builder.Configuration.GetSection("CarDatabase"));


builder.Services.AddScoped<IShirtRepository, ShirtRepository>();
builder.Services.AddScoped<HttpClient, HttpClient>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "VVS API",
        Version = "v1.0",
        Description = "Communication with Shirt Magazine."
    });

    // Set the comments path for the Swagger JSON and UI.
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    
});

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

app.Run();
