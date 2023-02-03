using FactoryMethod.ServiceMessage.Domain.Entities;
using FactoryMethod.ServiceMessage.Domain.Interface;

namespace FactoryMethod.ServiceMessage.Factory
{
    // Criadores concretos
    public class MobileMessage : CreatorMessage
    {
        public override void CreateChannel(string text)
        {
            this.Channels.Add(new ChatGPT(text));
            this.Channels.Add(new Whatsapp(text));
            this.Channels.Add(new Discord(text));
        }
    }
}
