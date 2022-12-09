using AbstractFactory.Example_1.Domain.Entities;
using AbstractFactory.Example_1.Domain.Interface;
using AbstractFactory.Example_1.EndPoints;
using AbstractFactory.Example_1.Validators;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers().AddJsonOptions(options =>
           options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

builder.Services.AddScoped<IValidator<object>, PizzaValidator<object>>();
builder.Services.AddSwaggerGen(op =>
{
    op.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Delivery Pizza",
        Version = "version",
        Description = "The Goal project is show the use pattern Abstract Factory",
        Contact = new OpenApiContact
        {
            Name = "Renan Alpoim Volkers",
            Email = "renanvolkers@hotmail.com",
            Url = new Uri("https://www.linkedin.com/in/renanvolkers/"),

        }
    });
    
});
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();




app.MapPizzaEndPoints();


app.Run();

