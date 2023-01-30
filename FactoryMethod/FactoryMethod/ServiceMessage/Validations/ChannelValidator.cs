using FactoryMethod.ServiceMessage.Domain.Interface;
using FluentValidation;

namespace FactoryMethod.ServiceMessage.Validators
{
    public class ChannelValidator<T> : AbstractValidator<Channel>
    {
        public ChannelValidator()
        {
            RuleFor(o=> o.Text).NotEmpty().NotNull();
        }
    }

}
