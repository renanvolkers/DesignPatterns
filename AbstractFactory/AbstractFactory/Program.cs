using AbstractFactory.Domain.Interface;
using AbstractFactory.Domain.ValueObj;
using AbstractFactory.StorePizza;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers().AddJsonOptions(options =>
           options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
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




app.MapGet("/StorePizza/{city}/{typePizza}", (
   [FromQuery] City city,
   [FromQuery] TypePizza typePizza
   ) =>
{
    DependentPizzaStore main = new DependentPizzaStore();

    var pizza = main.CreatePizza(city, typePizza);
    return pizza is IPizza ? Results.Ok(pizza.StatusDescription)
                          : Results.NotFound();
})
.ProducesValidationProblem()
.Produces(StatusCodes.Status400BadRequest)
.WithName("StorePizza")
.WithOpenApi();

app.Run();

