namespace Prototype.Domain
{
    public class Experience 
    {
        public string? Company { get; set; }
        public int Years { get; set; }
        public Experience ShallowClone()
        {
            return (Experience)MemberwiseClone();

        }

    }
}
