using AbstractFactory.Example_1.Domain.Entities;
using AbstractFactory.Example_1.Domain.Interface;
using AbstractFactory.Example_1.Domain.ValueObj;

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
        }

        public static IResult Get(City city, TypePizza typePizza)
        {
            DependentPizzaStore main = new DependentPizzaStore();

            var pizza = main.CreatePizza(city, typePizza);
            return pizza is IPizza ? Results.Ok(pizza.StatusDescription)
                                  : Results.NotFound();
        }
    }
}
