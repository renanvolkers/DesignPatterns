using Microsoft.AspNetCore.Mvc;

namespace AbstractFactory.EndPoints
{
    public static class  EndPoints
    {
        public static void MapComputerEndPoints(this WebApplication app)
        {

            app.MapPost("/createOperationalSystem/", CreateOs)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("createOperationalSystem")
                .WithOpenApi();

        }

        public static  IResult CreateOs()
        {

            return ""  is string ? Results.Created("teste", "")
                                  : Results.BadRequest();
        }


    }
}
