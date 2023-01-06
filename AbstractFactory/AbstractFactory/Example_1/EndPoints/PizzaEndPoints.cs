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
        public static void MapPizzaEndPoints(this WebApplication app)
        {
            app.MapGet("/StorePizza/{city}/{typePizza}", Get)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("StorePizza")

                .WithOpenApi();

            app.MapPost("/createPiza/", Create)
                .AddEndpointFilter<ValidationFilter<EmptyPizza>>()
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("createPiza")

                .WithOpenApi();
        }

        public static async Task<IResult> Get(ContextDataBase context, [FromQuery] City city, [FromQuery] TypePizza typePizza)
        {
            DependentPizzaStore main = new DependentPizzaStore();

            var pizza = await context.Get(x => x.Name != null).FirstOrDefaultAsync();

            return pizza is Product ? Results.Ok(pizza)
                                  : Results.NotFound();
        }

        public static  async Task<IResult> Create(ContextDataBase context, EmptyPizza pizza1)
        {
            DependentPizzaStore main = new DependentPizzaStore();
            IPizza pizza = new NYStyleCheesePizza();

            //await context.AddAsync(new Product { Name="Renan Alpoim Volkers"});
            //await context.SaveChangesAsync();

            return pizza is IPizza ? Results.Created("teste",pizza)
                                  : Results.BadRequest();
        }

    }
}
