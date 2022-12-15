using FluentValidation.Results;

namespace AbstractFactory.Example_1.Extensions
{
    public static class ValidationFilterFactory
    {
        public static string GetErrors(this List<ValidationFailure> erros)
        {
            var errorMessages = "";
            erros.ForEach(err => errorMessages += err.ErrorMessage + " ");

            return errorMessages;
        }

        public static IDictionary<string, string[]> AsDictionary(this List<ValidationFailure> erros)
        {

            var dictionary = new Dictionary<string, string[]>();
            dictionary.Add("Errors", erros.Select(x => x.ToString()).ToArray());

            return dictionary;
        }
        public static IDictionary<string, string[]> ToDictionary(this ValidationResult validationResult)
        {
            return validationResult.Errors
              .GroupBy(x => x.PropertyName)
              .ToDictionary(
                g => g.Key,
                g => g.Select(x => x.ErrorMessage).ToArray()
              );
        }
    }
}
