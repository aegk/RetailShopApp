using MediatR;
using AutoMapper;
using RetailShopApp.Application;
using System.Reflection;
using RetailShopApp.Domain.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(typeof(Initializer).Assembly);
var assemblies = new Assembly[]
    {
        typeof(Program).Assembly,
        typeof(Initializer).Assembly,
    };

builder.Services.AddAutoMapper(assemblies);
builder.Services.AddScoped<IBillDiscountService, BillDiscountService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseRouting();
    
}




app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
