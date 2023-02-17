using AbstractFactory.Exemple_2.Domain;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace AbstractFactory.Example_1.EndPoints
{
    public static class ProductExemplo2Points
    {
        public static void MapProductExemplo2(this WebApplication app)
        {
            app.MapGet("/product/{name}", Get)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("getProduct")
                .WithOpenApi();
        }

        public static async Task<IResult> Get(string name)
        {
            Product pro;
            return pro is List<Product> ? Results.Ok(pro)
                                  : Results.NotFound();
        }

    }
}
