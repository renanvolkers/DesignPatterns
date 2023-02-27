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

            app.MapGet("/SameInstance/", GetSingletoVetor)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("SameInstance")
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


    }
}
