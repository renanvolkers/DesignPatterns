using FactoryMethod.ServiceMessage.Domain.ValeuObj;
using static System.Net.Mime.MediaTypeNames;

namespace FactoryMethod.ServiceMessage.Factory
{
    //Application
    public class ServiceChannel
    {
        CreatorMessage? message;
        private string _text;
        public ServiceChannel(ChannelType type,string text) {
            _text = text;
            Initialize(type);
        }

        public void Initialize(ChannelType type)
        {
            switch (type)
            {
                case ChannelType.Mobile :
                    message = new MobileMessage();
                    break;

                case ChannelType.Web:
                    message = new WebMessage();
                    break;


                default: throw new Exception("Error! Unknown operating system.");
                    break;
            }
            message.CreateChannel(_text);
            
            
        }
        public List<string> SendMessage()
        {
          return  message.SendMessage();
        }
    }
}
