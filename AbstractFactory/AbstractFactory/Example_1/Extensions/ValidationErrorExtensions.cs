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
            dict.Add("Errors", erros.Select(x => x.ToString()).ToArray());

            return dictionary;
        }
    }
}
