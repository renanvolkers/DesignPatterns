namespace Prototype.Domain
{
    public interface IEmployee
    {
        IEmployee Clone();
        string GetDetails();
    }
}
