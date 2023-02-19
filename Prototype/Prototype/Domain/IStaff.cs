namespace Prototype.Domain
{
    public interface IStaff
    {
        IStaff ShallowClone();
        IStaff DeepClone();
        string GetDetails();
    }
}
