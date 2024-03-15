using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Services;
using HouseRentingSystem.Infrastructure.Data;
using HouseRentingSystem.Infrastructure.Data.Common;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<HouseRentingDbContext>(options =>
    options.UseSqlServer(connectionString));

// Add services to the container.

builder.Services.AddScoped<IRepository, Repository>();

builder.Services.AddScoped<IHouseService, HouseService>();

builder.Services.AddCors(setup =>
{
    setup.AddPolicy("HouseRentingSystem", policyBuilder =>
    {
        policyBuilder
        .WithOrigins("https://localhost:7192")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors("HouseRentingSystem");

app.Run();
