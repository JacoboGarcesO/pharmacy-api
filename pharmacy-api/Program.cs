using Microsoft.EntityFrameworkCore;
using pharmacy_api.Database;
using pharmacy_api.Database.Interfaces;
using pharmacy_api.Database.Repositories;
using pharmacy_api.Services;
using pharmacy_api.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<Database>(options => options.UseSqlServer(builder.Configuration["SQLConnectionString"]));
builder.Services.AddScoped<IDatabase, Database>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerService, CustomerService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
