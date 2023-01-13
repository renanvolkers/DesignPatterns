using AbstractFactory;
using AbstractFactory.Example_1.Domain.Entities;
using AbstractFactory.Example_1.EndPoints;
using AbstractFactory.Example_1.Validators;
using AbstractFactory.Exemple_2.Domain;
using AbstractFactory.Exemple_2.Factories;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers().AddJsonOptions(options =>
           options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));


builder.Services.AddScoped<IValidator<EmptyPizza>, PizzaValidator<EmptyPizza>>();

builder.Services.AddDbContext<MinimalContextDb>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IApplicationDB>(x => new ApplicationDB(builder.Configuration.GetConnectionString("DefaultConnection")));

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
//app.MapExemple2EndPoints();


app.Run();

