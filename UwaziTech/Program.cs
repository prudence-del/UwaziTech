using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using UwaziTech.Core.Services;
using UwaziTech.Core.Services.Interfaces;
using UwaziTech.Infrastructure.Context;
using System.IO;

var builder = WebApplication.CreateBuilder(args);

// Configure appsettings.json location (Custom Path)
builder.Configuration
    .SetBasePath(Path.Combine(AppContext.BaseDirectory, "API")) // Point to the API folder
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true);

// Add services to the container
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register services & lifetimes
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IHospitalService, HospitalService>();
builder.Services.AddTransient<IInsuranceService, InsuranceService>();

// Use connection string from appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Register AppDbContext with the connection string
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString)
);

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
