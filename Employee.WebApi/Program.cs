using EmployeeManagement.Infrastructure.Persistence;
using EntityFramework;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Services;
using EmployeeManagment.Application.Interfaces;
using EmployeeManagement.Application.Map;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(IService<>), typeof(CrudService<>));
builder.Services.AddScoped(typeof(IEntityRepository<>), typeof(CrudRepository<>));
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddDbContext<EmployeeManagmentDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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
