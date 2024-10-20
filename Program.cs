using Microsoft.EntityFrameworkCore;
using todo_app.Data.Context;
using todo_app.Data.Repositories;
using todo_app.Domain.Interfaces.Repository;
using todo_app.Domain.Interfaces.Service;
using todo_app.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Register your services here
builder.Services.AddScoped<ISimpleTodoService, SimpleTodoService>();
builder.Services.AddScoped<ITimedTodoService, TimedTodoService>();
builder.Services.AddScoped<ITimedTodoRepository, TimedTodoRepository>();
builder.Services.AddScoped<ISimpleTodoRepository, SimpleTodoRepository>();

builder.Services.AddDbContext<AppDbContext>(
    options => options.UseNpgsql(builder.Configuration.GetConnectionString("ApiDatabase")));

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

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