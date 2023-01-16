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

            app.MapPost("/product/", Create)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("product")
                .WithOpenApi();

        }

        public static async Task<IResult> Get(MinimalContextDb context ,string name)
        {
               var products =await context.Products.Where(x=>x.Name== name).ToListAsync();

            return products is List<Product> ? Results.Ok(products)
                                  : Results.NotFound();
        }
        public static async Task<IResult> Create(MinimalContextDb context, Product product)
        {
            var result = await context.AddAsync(product);
            await context.SaveChangesAsync();
            return product is Product ? Results.Created("teste", product)
                                  : Results.BadRequest();
        }

    }
}
