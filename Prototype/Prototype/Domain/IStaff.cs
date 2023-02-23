namespace Prototype.Domain
{
    public interface IStaff
    {
        Guid Id { get; set; }
        IStaff ShallowClone();
        IStaff DeepClone();
        string GetDetails();
    }
}
