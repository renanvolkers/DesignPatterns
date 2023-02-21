using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Prototype.Domain;

namespace Prototype.EndPoints
{
    public static class EmployeeEndPoints
    {
        public static List<IStaff> staff = new();
        public static void MapEmployeeEndPoints(this WebApplication app)
        {
            app.MapGet("/Staff/", Get)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("GetStaff")
                .WithOpenApi();

            app.MapGet("/ShallowClone/", ShallowClone)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("ShallowClone")
                .WithOpenApi();

            app.MapGet("/DeepClone/", DeepClone)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("DeepClone")
                .WithOpenApi();

            app.MapPost("/EngineerSoftware/", PostEngineerSoftware)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("PostEngineerSoftware")
                .WithOpenApi();

            app.MapPost("/Typist/", PostTypist)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("PostTypist")
                .WithOpenApi();


        }

        public static IResult Get([FromQuery]TypeEmployee typeEmployee)
        {
            var filterStaff = Application.FilterStaff(typeEmployee, staff);

            return filterStaff is List<IStaff> ? Results.Ok(filterStaff.Select(x => x.GetDetails()))
                                  : Results.NotFound();
        }
        public static IResult GetEngineerSoftware()
        {
            var filterStaff = Application.FilterStaff(TypeEmployee.EngineerSoftware, staff);

            return filterStaff is List<EngineerSoftware> ? Results.Ok(filterStaff.Select(x => x.GetDetails()))
                                  : Results.NotFound();
        }
        
        public static IResult GetTypist()
        {
            var filterStaff = Application.FilterStaff(TypeEmployee.Typist, staff);

            return filterStaff is List<Typist> ? Results.Ok(filterStaff.Select(x => x.GetDetails()))
                                  : Results.NotFound();
        }
        public static IResult DeepClone([FromQuery] TypeEmployee typeEmployee)
        {
            var filterStaff = Application.DeepClone(typeEmployee, staff);

            return filterStaff is List<IStaff> ? Results.Ok(filterStaff.Select(x=>x.GetDetails()))
                                  : Results.NotFound();
        }
        public static IResult ShallowClone([FromQuery] TypeEmployee typeEmployee)
        {
            var filterStaff = Application.ShallowClone(typeEmployee, staff);

            return filterStaff is List<IStaff> ? Results.Ok(filterStaff.Select(x => x.GetDetails()))
                                  : Results.NotFound();
        }

        public static IResult PostEngineerSoftware(EngineerSoftware typeEmployee)
        {
            staff.Add(typeEmployee);

            return staff is List<IStaff> ? Results.Ok(typeEmployee)
                                  : Results.NotFound();
        }

        public static IResult PostTypist(Typist typeEmployee)
        {
            staff.Add(typeEmployee);

            return staff is List<IStaff> ? Results.Ok(typeEmployee)
                                  : Results.NotFound();
        }

    }
}
