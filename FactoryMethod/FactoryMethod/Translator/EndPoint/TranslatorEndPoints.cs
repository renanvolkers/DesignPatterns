using FactoryMethod;
using FactoryMethod.Translator.Domain.Interface;
using FactoryMethod.Translator.Domain.ValeuObj;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace AbstractFactory.Example_1.EndPoints
{
    public static class  TranslatorEndPoints
    {
        public static List<ILanguage> languages { get; set; } = new List<ILanguage>();
        public static void MapLanguageEndPoints(this WebApplication app)
        {
            app.MapGet("/TypeText/{typeLanguage}/", Get)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("TextCommom")
                .WithOpenApi();

            app.MapGet("/PossessiveAdjective/{typeLanguage}/", GetPossessiveAdjective)
                .ProducesValidationProblem()
                .Produces(StatusCodes.Status400BadRequest)
                .WithName("PossessiveAdjective")
                .WithOpenApi();


        }

        public static  IResult Get(MinimalContextDb context,[FromQuery] Language language)
        {
            languages = languages.ToList();

            return languages is List<ILanguage> ? Results.Ok(languages)
                                  : Results.NotFound();
        }

        public static IResult GetPossessiveAdjective(MinimalContextDb context,[FromQuery] Language language)
        {
            languages = languages.ToList();

            return languages is List<ILanguage> ? Results.Ok(languages)
                                  : Results.NotFound();
        }

    }
}
