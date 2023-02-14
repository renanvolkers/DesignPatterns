using Builder.Domain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AbstractFactory.EndPoints
{
    public static class  ComputerEndPoints
    {
        public static void MapComputerEndPoints(this WebApplication app)
        {

            app.MapPost("/createOperationalSystem/", CreateOs)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("createOperationalSystem")
                .WithOpenApi();

            app.MapPost("/createHardware/", CreateHardware)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("createHardware")
                .WithOpenApi();
        }

        public static async Task<IResult> CreateOs([FromQuery] TypeOS typeOS)
        {
            var diretor = new Director();
            var builder = new OperationalSystemBuilder();

            if (TypeOS.Windows == typeOS)
            {
                diretor.OperationalSystemWindows(builder);
            }

            if (TypeOS.Linux == typeOS)
            {
                diretor.OperationalSystemLinux(builder);
            }
            var operationalSystem = builder.GetOS();
            return operationalSystem is OperationalSystem ? Results.Created("teste", operationalSystem)
                                  : Results.BadRequest();
        }
        public static async Task<IResult> CreateHardware([FromQuery] TypeHardware typeHardware)
        {
            var diretor = new Director();
            var builder = new HardwareBuilder();

            if (TypeHardware.Intel == typeHardware)
            {
                diretor.Buildcomputer(builder);
            }

            var computer = builder.GetNotbook();
            return computer is Notbook ? Results.Created("teste", computer)
                                  : Results.BadRequest();
        }

    }
}
