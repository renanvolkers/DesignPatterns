namespace Builder.Domain
{
    public class OperationalSystem
    {
        public string? Name { get; set; }
        public int Raw { get; set; }
        public string? Processador { get; set; }
        public int Cpu { get; set; }
        public string? Monitor { get; set; }
        public string? Audio { get; set; }
        public string? Video { get; set; }
        public string? Wifi { get; set; }

        public List<string> Programs { get; set; } = new List<string>();

        public int ConsumerMemory()
        {
            return (this.Programs.Count / Raw) / Cpu;
        }
    }
}
