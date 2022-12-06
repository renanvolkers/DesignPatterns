using AbstractFactory.Example_1.Domain.Interface;
using FluentValidation;

namespace AbstractFactory.Example_1.Validators
{
    public class PizzaValidator : AbstractValidator<IPizza>
    {
        public PizzaValidator()
        {
            RuleFor(o=> o.Name).NotEmpty().NotNull().MinimumLength(4);
            RuleFor(o => o.Size).NotNull().GreaterThanOrEqualTo(2);

        }
    }

}
