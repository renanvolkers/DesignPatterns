namespace FactoryMethod.ServiceMessage.Domain.Interface
{
    public abstract class Channel
    {
       public abstract string? Text { get; }
       public abstract string SendMessage();
    }
}
