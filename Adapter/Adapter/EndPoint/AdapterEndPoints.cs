using Adapter.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Reflection.Metadata;

namespace Adapter.EndPoints
{
    public static class AdapterEndPoints
    {
        public static void MapAdapterAppEndPoints(this WebApplication app)
        {
            app.MapGet("/Adapter/", Get)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("Adapter")
                .WithOpenApi();

        }

        public static IResult Get([FromQuery]DataBase type)
        {
            DbAdapter conection;
            if(type == DataBase.Oracle)
            {
                conection = new OracleCommands();
            }
            else
            {
                conection = new MySqlAdapter(new MySqlCommands());
            }

            string msg = conection.ConectionDb();

            
            msg = msg + conection.Insert();
            msg = msg + conection.Update();
            msg = msg + conection.Delete();

            return msg is string ? Results.Ok(msg)
                                  : Results.NotFound();
        }


    }
}
