using Microsoft.EntityFrameworkCore;
using PizzeriaOrder.Api.Data;
using PizzeriaOrder.Api.Services.Menu;
using PizzeriaOrder.Api.Services.Orders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<PizzeriaDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")));

// Controllers
builder.Services.AddControllers();
builder.Services.AddScoped<IMenuService, MenuService>();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IOrderService, OrderService>();

// CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowFrontend");

app.MapControllers();

app.Run();