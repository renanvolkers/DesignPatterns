using AbstractFactory.Example_1.Domain.Interface;
using FluentValidation;

namespace AbstractFactory.Example_1.Validators
{
    public class PizzaValidator<T> : AbstractValidator<IPizza>
    {
        public PizzaValidator()
        {
            RuleFor(o=> o.Name).NotEmpty().NotNull().MinimumLength(5);
            RuleFor(o => o.Size).NotNull().GreaterThanOrEqualTo(2);

        }
    }

}
