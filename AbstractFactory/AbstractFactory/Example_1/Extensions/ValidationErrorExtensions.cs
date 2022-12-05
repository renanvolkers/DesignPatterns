using FluentValidation.Results;

namespace AbstractFactory.Example_1.Extensions
{
    public static class ValidationErrorExtensions
    {
        public static string GetErros(this List<ValidationFailure> erros)
        {
            var errorMessages = "";
            erros.ForEach(err => errorMessages += err.ErrorMessage + " ");
            
            return errorMessages;
        }
    }
}
