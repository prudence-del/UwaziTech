using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using UwaziTech.Core.Services;
using UwaziTech.Core.Services.Interfaces;
using UwaziTech.Infrastructure.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//register services & lifetime
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IHospitalService, HospitalService>();
builder.Services.AddTransient<IInsuranceService, InsuranceService>();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var conn = "Server=localhost;Database=insurancestore;User ID=sa;Password=p@55w0rd!;MultipleActiveResultSets=True;TrustServerCertificate=True;";


builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(conn)
);


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
