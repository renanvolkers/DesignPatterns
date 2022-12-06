using AbstractFactory.Example_1.Domain.Entities;
using AbstractFactory.Example_1.Domain.Interface;
using AbstractFactory.Example_1.Domain.ValueObj;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

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

                .WithOpenApi() ;

            app.MapPost("/StorePizza/{city}/{typePizza}", Create).AddFilter(async (routeHandlerInvocationContext, next) =>
            {
                var name = (string)routeHandlerInvocationContext.Parameters[0];
				var pizza = (IPizza)routeHandlerInvocationContext.Parameters[1];
                if (name == "Bob")
                {
                    return Results.Problem("No Bob's allowed");
                }
                return await next(routeHandlerInvocationContext);
            }).ProducesValidationProblem();
        }

        public static IResult Get(IValidator<IPizza> validator ,[FromQuery] City city, [FromQuery] TypePizza typePizza)
        {
            DependentPizzaStore main = new DependentPizzaStore();

            var pizza = main.CreatePizza(city, typePizza);

            return pizza is IPizza ? Results.Ok(pizza.StatusDescription)
                                  : Results.NotFound();
        }

        public static  IResult Create(IPizza pizza,IValidator<IPizza> validator)
        {
            DependentPizzaStore main = new DependentPizzaStore();
            

            return pizza is IPizza ? Results.Ok(pizza.StatusDescription)
                                  : Results.NotFound();
        }

    }
}
