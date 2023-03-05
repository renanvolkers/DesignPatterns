namespace Adapter.EndPoints
{
    public static class AdapterEndPoints
    {
        public static void MapSingletonAppEndPoints(this WebApplication app)
        {
            app.MapGet("/Adapter/", Get)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("Adapter")
                .WithOpenApi();

        }

        public static IResult Get()
        {
            //var teste = new Application();
            //var result = teste.VerificarVetor();
            //return result is VetorExercice<int> ? Results.Ok(result)
            //                      : Results.NotFound();
            return null;
        }


    }
}
