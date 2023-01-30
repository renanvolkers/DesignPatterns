using FactoryMethod.ServiceMessage.Domain.Entities;

namespace FactoryMethod.ServiceMessage.Factory
{
    // Creates concretos
    public class WebMessage : CreatorMessage
    {
        public override void CreateChannel(string text)
        {
            Channels.Add(new Email(text));
        }

    }
}
