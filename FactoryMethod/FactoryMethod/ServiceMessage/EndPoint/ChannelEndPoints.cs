using FactoryMethod.ServiceMessage.Domain.ValeuObj;
using FactoryMethod.ServiceMessage.Factory;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace FactoryMethod.Example_1.EndPoints
{
    public static class ChannelEndPoints
    {
        public static void MapChannelEndPoints(this WebApplication app)
        {
            app.MapGet("/TypeText/{typeChannel}/", Get)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("Channel")
                .WithOpenApi();

        }

        public static  IResult Get([FromQuery] ChannelType channel,string text)
        {
            var serviceChannel = new ServiceChannel(channel, text);
            var message = serviceChannel.SendMessage();

            return message is List<string> ? Results.Ok(message)
                                  : Results.NotFound();
        }

    }
}
