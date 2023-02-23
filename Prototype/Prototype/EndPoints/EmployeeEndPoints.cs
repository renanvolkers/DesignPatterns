using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Prototype.Domain;

namespace Prototype.EndPoints
{
    public static class EmployeeEndPoints
    {
        public static List<IStaff> staffs = new();
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
            app.MapPut("/EngineerSoftware/", PutEngineerSoftware)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("PutEngineerSoftware")
                .WithOpenApi();

            app.MapPost("/Typist/", PostTypist)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("PostTypist")
                .WithOpenApi();




        }

        public static IResult Get([FromQuery]TypeEmployee typeEmployee)
        {
            var filterStaff = Application.FilterStaff(typeEmployee, staffs);

            return filterStaff is List<IStaff> ? Results.Ok(filterStaff.Select(x => x.GetDetails()))
                                  : Results.NotFound();
        }
        public static IResult GetEngineerSoftware()
        {
            var filterStaff = Application.FilterStaff(TypeEmployee.EngineerSoftware, staffs);

            return filterStaff is List<IStaff> ? Results.Ok(filterStaff.Select(x => x.GetDetails()))
                                  : Results.NotFound();
        }
        
        public static IResult GetTypist()
        {
            var filterStaff = Application.FilterStaff(TypeEmployee.Typist, staffs);

            return filterStaff is List<IStaff> ? Results.Ok(filterStaff.Select(x => x.GetDetails()))
                                  : Results.NotFound();
        }
        public static IResult DeepClone([FromQuery] TypeEmployee typeEmployee)
        {
            var filterStaff = Application.DeepClone(typeEmployee, staffs);

            return filterStaff is List<IStaff> ? Results.Ok(filterStaff.Select(x=>x.GetDetails()))
                                  : Results.NotFound();
        }
        public static IResult ShallowClone([FromQuery] TypeEmployee typeEmployee)
        {
            Application.ShallowClone(typeEmployee, staffs);
           

            return staffs is List<IStaff> ? Results.Ok(staffs.Select(x => x.GetDetails()))
                                  : Results.NotFound();
        }

        public static IResult PostEngineerSoftware(EngineerSoftware typeEmployee)
        {
            typeEmployee.Id = Guid.NewGuid();
            staffs.Add(typeEmployee);

            return staffs is List<IStaff> ? Results.Ok(typeEmployee)
                                  : Results.NotFound();
        }
        public static IResult PutEngineerSoftware(EngineerSoftware typeEmployee)
        {
            EngineerSoftware staff = (EngineerSoftware)Application.GetById(typeEmployee.Id, staffs);
            if (staff !=null)
            {
                staff.WordsPerMinute = typeEmployee.WordsPerMinute;
                staff.PreferredLanguage = typeEmployee.PreferredLanguage;
                staff.MoneyPerHours = typeEmployee.MoneyPerHours;
                staff.Experiences = typeEmployee.Experiences;
            }

            return staff is IStaff ? Results.Ok(typeEmployee)
                                  : Results.NotFound();
        }

        public static IResult PostTypist(Typist typeEmployee)
        {
            staffs.Add(typeEmployee);

            return staffs is List<IStaff> ? Results.Ok(typeEmployee)
                                  : Results.NotFound();
        }

    }
}
