using Builder.Domain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System;

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

        public static  IResult CreateOs([FromQuery] TypeOS typeOS)
        {
            var operationalSystem = new Application().MakeOperationalSystem(typeOS);

            return operationalSystem is OperationalSystem ? Results.Created("teste", operationalSystem)
                                  : Results.BadRequest();
        }
        public static  IResult CreateHardware([FromQuery] TypeHardware typeHardware)
        {
            var notbook = new Application().MakeNotbook(typeHardware);
            return notbook is Notbook ? Results.Created("teste", notbook)
                                  : Results.BadRequest();
        }

    }
}
