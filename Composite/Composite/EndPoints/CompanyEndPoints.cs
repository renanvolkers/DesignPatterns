using Composite.Domain;

namespace Composite.EndPoints
{
    public static class CompanyEndPoints
    {
        public static void MapCompanyEndPoints(this WebApplication app)
        {

            app.MapPost("/Company/", Get)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("Company")
                .WithOpenApi();

        }

        public static  IResult Get()
        {
            Company company = new Company();
            var hierarchy = company.Execurte();

            return hierarchy is string ? Results.Ok(hierarchy)
                                  : Results.BadRequest();
        }


    }
}
