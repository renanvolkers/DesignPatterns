namespace Prototype.Domain
{
    public interface IStaff
    {
        public Guid Id { get; set; }
        string? Name { get; set; }
        IStaff ShallowClone();
        IStaff DeepClone();
        string GetDetails();
    }
}
