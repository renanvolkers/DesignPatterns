using Microsoft.VisualBasic;

namespace Prototype.Domain
{
    public interface IStaff
    {
        public Guid Id { get; set; }
        public List<Experience> Experiences { get; set; }
        public InfoStaff InfoStaff { get; set; }
        string? Name { get; set; }
        IStaff ShallowClone();
        IStaff DeepClone();
        string GetDetails();
    }
}
