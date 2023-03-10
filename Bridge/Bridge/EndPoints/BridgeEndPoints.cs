using Bridge.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Bridge.EndPoints
{
    public static class BridgeEndPoints
    {
        public static void MapBridgeAppEndPoints(this WebApplication app)
        {
            app.MapPost("/Bridge/", Post)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("Bridge")
                .WithOpenApi();

        }

        public static IResult Post(Employee employee,[FromQuery]TypeFile type)
        {
            Application app = new Application();
           var fileName = app.FileEmployee(employee, type);

            string path = Path.GetFullPath(fileName);
            return employee is Employee ? Results.File(path)
                                  : Results.NotFound();
        }


    }
}
