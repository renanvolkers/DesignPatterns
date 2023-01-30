using FactoryMethod.ServiceMessage.Domain.Interface;

namespace FactoryMethod.ServiceMessage.Domain.Entities
{
    public class Email : Channel
    {
        private readonly string _Text;
        public Email(string text)
        {
            this._Text = text;
        }

        public override string? Text { get => _Text; }

        public override string SendMessage()
        {
            return "Messsage send Email";
        }
    }
}
