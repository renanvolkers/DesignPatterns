using FactoryMethod.Translator.Domain.Entities;
using FluentValidation;

namespace FactoryMethod.Translator.Validators
{
    public class GramaticValidator<T> : AbstractValidator<Gramatic>
    {
        public GramaticValidator()
        {
            RuleFor(o=> o.PossessiveAdjective).NotEmpty().NotNull();
            RuleFor(o => o.PromonounsObject).NotNull();
        }
    }

}
