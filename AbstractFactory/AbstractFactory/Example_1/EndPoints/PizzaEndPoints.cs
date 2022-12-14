using AbstractFactory.Example_1.Domain.Entities;
using AbstractFactory.Example_1.Domain.Interface;
using AbstractFactory.Example_1.Domain.ValueObj;
using AbstractFactory.Example_1.Extensions;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace AbstractFactory.Example_1.EndPoints
{
    public static class  PizzaEndPoints
    {
        public static void MapPizzaEndPoints(this WebApplication app)
        {
            //app.MapGet("/StorePizza/{city}/{typePizza}", Get)
            //    .ProducesValidationProblem()
            //    .Produces(StatusCodes.Status400BadRequest)
            //    .WithName("StorePizza")

            //    .WithOpenApi();

            app.MapPost("/createPiza/", Create)
                .AddEndpointFilter<ValidationFilter<EmptyPizza>>()
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("createPiza")

                .WithOpenApi();
        }

        public static IResult Get([FromQuery] City city, [FromQuery] TypePizza typePizza)
        {
            DependentPizzaStore main = new DependentPizzaStore();

            var pizza = main.CreatePizza(city, typePizza);

            return pizza is IPizza ? Results.Ok(pizza.StatusDescription)
                                  : Results.NotFound();
        }

        public static  IResult Create(EmptyPizza pizza1)
        {
            DependentPizzaStore main = new DependentPizzaStore();
            IPizza pizza = null;

            return pizza is IPizza ? Results.Ok(pizza.StatusDescription)
                                  : Results.NotFound();
        }

    }
}
