using Singleton.Domain;

namespace Singleton.EndPoints
{
    public static class SingletonAppEndPoints
    {
        public static List<int> contagem { get; set; } = new List<int>();
        public static void MapSingletonAppEndPoints(this WebApplication app)
        {
            app.MapGet("/Singleton/", Get)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("Singleton")
                .WithOpenApi();

            app.MapGet("/ConfigSingletonMicrosoftNetCore/", GetSingletoNetCore)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("ConfigSingletonMicrosoftNetCore")
                .WithOpenApi();

            app.MapGet("/SameInstance/", GetSingletoVetor)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("SameInstance")
                .WithOpenApi();

            app.MapGet("/BlueSort/", GetBlueSort)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("GetBlueSort")
                .WithOpenApi();

        }

        public static IResult Get()
        {
            var teste = new Application();
            var result = teste.VerificarVetor();
            return result is VetorExercice<int> ? Results.Ok(result)
                                  : Results.NotFound();
        }

        public static IResult GetSingletoVetor()
        {
            var teste = new Application();
            var result = teste.SameInstance();
            return result is VetorExercice<string> ? Results.Ok(result)
                                  : Results.NotFound();
        }

        public static IResult GetSingletoNetCore(ISingletonService singletonService)
        {
            var result = singletonService.GetUnits();
           
            return result is UnitOptions ? Results.Ok(result)
                                  : Results.NotFound();
        }


        public static IResult GetBlueSort()
        {
            var teste = new Application();
            var result = teste.bubbleSort();
            return result is VetorExercice<int> ? Results.Ok(result)
                                  : Results.NotFound();
        }



    }
}
