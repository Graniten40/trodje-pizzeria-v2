using Microsoft.EntityFrameworkCore;
using PizzeriaOrder.Api.Data;
using PizzeriaOrder.Api.Services.Email;
using PizzeriaOrder.Api.Services.Menu;
using PizzeriaOrder.Api.Services.Orders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<PizzeriaDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")));

// Controllers
builder.Services.AddControllers();

// Services
builder.Services.AddScoped<IMenuService, MenuService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IEmailService, BrevoEmailService>();

// HttpClient för Brevo
builder.Services.AddHttpClient();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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