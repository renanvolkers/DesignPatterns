namespace Prototype.Domain
{
    public class Developer : IEmployee
    {
        public int WordsPerMinute { get; set; }
        public string? Name { get; set; }
        public string? Role { get; set; }
        public string? PreferredLanguage { get; set; }
        public double MoneyPerHours { get; set; }

        public IEmployee Clone()
        {
            return (IEmployee)MemberwiseClone();

        }

        public IEmployee CloneDeep()
        {
            return (IEmployee)this.Clone();
        }

        public string GetDetails()
        {
            return string.Format("{0} - {1} - {2}", Name, Role, PreferredLanguage);
        }
    }


}
