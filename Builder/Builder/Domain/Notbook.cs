namespace Builder.Domain
{
    public class Notbook
    {
        public string? Name { get; set; }
        public string? Company { get; set; }
        public string? Raw { get; set; }
        public string? HdSsd { get; set; }
        public string? Audio { get; set; }
        public string? Wifi { get; set; }
        public string? Usb { get; set; }
        public string? Monitor { get; set; }
        public string? Processador { get; set; }
        public string? MotherBoard{ get; set; }

        public List<string> SlotRaw { get; set; } = new List<string>();
    }
}
