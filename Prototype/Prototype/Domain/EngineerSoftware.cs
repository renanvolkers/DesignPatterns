namespace Prototype.Domain
{
    public class EngineerSoftware : IStaff
    {
        public int Id { get; set; }

        public int WordsPerMinute { get; set; }
        public string? Name { get; set; }
        public string? Role { get; set; }
        public string? PreferredLanguage { get; set; }
        public double MoneyPerHours { get; set; }

        public List<Experience> Experiences { get; set; } = new List<Experience>();

        public IStaff ShallowClone()
        {
            return (IStaff)MemberwiseClone();

        }

        public IStaff DeepClone()
        {
            EngineerSoftware dev = new EngineerSoftware();
            dev = (EngineerSoftware)this.ShallowClone();
            dev.Experiences = new List<Experience>();
            this.Experiences.ForEach(x  => { dev.Experiences.Add(x.ShallowClone()); });

            return dev;
        }

        public string GetDetails()
        {
          var list =  string.Join("\n", this.Experiences.Select(x=>x.Company));
            return string.Format("{0} - {1} - {2} - {3}", Name, Role, PreferredLanguage, list);
        }
    }


}
