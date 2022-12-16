using AbstractFactory.Example_1.Domain.Entities;
using AbstractFactory.Example_1.Domain.Interface;
using AbstractFactory.Example_1.Domain.ValueObj;
using AbstractFactory.Example_1.Extensions;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace AbstractFactory.Example_1.EndPoints
{
    public static class Exemple2EndPoints
    {
        public static void MapExemple2EndPoints(this WebApplication app)
        {
            app.MapGet("/StorePizza/{city}/{typePizza} ", Get)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("StorePizza")

                .WithOpenApi();


        }

        public static IResult Get(IValidator<ChicagoStyleCheesePizza> validator, [FromQuery] City city, [FromQuery] TypePizza typePizza)
        {
            DependentPizzaStore main = new DependentPizzaStore();


            var pizza = main.CreatePizza(city, typePizza);

            return pizza is IPizza ? Results.Ok(pizza.StatusDescription)
                                  : Results.NotFound();
        }


    }
}
