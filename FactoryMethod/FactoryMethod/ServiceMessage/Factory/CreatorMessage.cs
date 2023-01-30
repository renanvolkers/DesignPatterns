using FactoryMethod.ServiceMessage.Domain.Interface;

namespace FactoryMethod.ServiceMessage.Factory
{
    public abstract class CreatorMessage
    {
        public List<Channel> Channels { get; set; } = new List<Channel> { };

        public CreatorMessage()
        {
        }
        public abstract void CreateChannel(string text);
        public List<string> SendMessage()
        {
            List<string> listMessage = new List<string>();
            this.Channels.ForEach(x => {
                listMessage.Add(x.SendMessage());
            });

            return listMessage;
        }
    }
}
