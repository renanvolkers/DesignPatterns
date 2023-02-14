using FluentValidation;

namespace Builder.Extensions
{
    public class ValidationFilter<T> : IEndpointFilter where T : class
    {
        private readonly IValidator<T> _validator;
        public ValidationFilter(IValidator<T> validator)
        {
            _validator = validator;
        }

        public async ValueTask<object> InvokeAsync(EndpointFilterInvocationContext context,
                      EndpointFilterDelegate next)
        {
            var parameter = context.Arguments.SingleOrDefault(p => p?.GetType() == typeof(T));

            if (parameter is null) return Results.BadRequest("O parametro é inválido/Type.");

            var result = await _validator.ValidateAsync((T)parameter);

            if (!result.IsValid)
            {
                return Results.ValidationProblem(result.ToDictionary());
            }
            // now the actual endpoint execution
            return await next(context);
        }

    }
}
