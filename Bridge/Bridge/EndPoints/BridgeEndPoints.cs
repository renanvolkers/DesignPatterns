using Bridge.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Bridge.EndPoints
{
    public static class BridgeEndPoints
    {
        public static void MapBridgeAppEndPoints(this WebApplication app)
        {
            app.MapGet("/Bridge/", Post)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("Bridge")
                .WithOpenApi();

        }

        public static IResult Post([FromQuery]TypeFile type,Employee employee)
        {
            Application app = new Application();
            app.FileEmployee(employee, type);
 

            return employee is Employee ? Results.Ok(employee)
                                  : Results.NotFound();
        }


    }
}
