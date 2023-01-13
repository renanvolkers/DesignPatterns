using AbstractFactory.Example_1.Domain.Entities;
using AbstractFactory.Example_1.Domain.Interface;
using AbstractFactory.Example_1.Domain.ValueObj;
using AbstractFactory.Example_1.Extensions;
using AbstractFactory.Exemple_2.Domain;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AbstractFactory.Example_1.EndPoints
{
    public static class  PizzaEndPoints
    {
        public static List<IPizza> pizzas { get; set; } = new List<IPizza>();
        public static void MapPizzaEndPoints(this WebApplication app)
        {
            app.MapGet("/StorePizza/{city}/{typePizza}", Get)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("StorePizza")

                .WithOpenApi();

            app.MapPost("/createPiza/", Create)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("createPiza")

                .WithOpenApi();
        }

        public static  IResult Get([FromQuery] City city, [FromQuery] TypePizza typePizza)
        {
            pizzas = pizzas.Where(x=>x.City == city && x.type == typePizza).ToList();

            return pizzas is List<IPizza> ? Results.Ok(pizzas)
                                  : Results.NotFound();
        }

        public static  async Task<IResult> Create([FromQuery] City city , [FromQuery] TypePizza typePizza)
        {
            DependentPizzaStore main = new DependentPizzaStore();
            IPizza pizza = main.CreatePizza(city,typePizza);
            pizzas.Add(pizza);
            return pizza is IPizza ? Results.Created("teste", pizzas)
                                  : Results.BadRequest();
        }

    }
}
