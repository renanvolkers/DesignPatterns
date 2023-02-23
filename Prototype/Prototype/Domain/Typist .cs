using Prototype.Domain;

namespace Prototype.Domain
{
    public class Typist : IStaff
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int WordsPerMinute { get; set; }
        public string? Name { get; set; }
        public string? Role { get; set; }
        public List<Experience> Experiences { get; set; } = new List<Experience>();
        public InfoStaff InfoStaff { get; set; } = new InfoStaff();

        public IStaff ShallowClone()
        {
            return (IStaff)MemberwiseClone();

        }

        public IStaff DeepClone()
        {
            return (IStaff)this.ShallowClone();
        }

        public string GetDetails()
        {
            return string.Format("{0} - {1} - {2}", Name, Role, WordsPerMinute);
        }
    }
}
