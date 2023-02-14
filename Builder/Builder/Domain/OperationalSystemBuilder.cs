namespace Builder.Domain
{
    public class OperationalSystemBuilder : IBuilder
    {
       public OperationalSystem OS { get; set; }

        public OperationalSystemBuilder() => Reset();

        public void Reset()
        {
           this.OS = new OperationalSystem();
        }

        public void ConfigAudio()
        {
        }
        public void Name(string name)
        {
            this.OS.Name = name;
        }

        public void Video()
        {
            this.OS.Video = "Gforce";
        }

        public void ConfigWireless()
        {
            this.OS.Wifi = "Beds";
        }

        public void Raw()
        {
        }

        public void USB()
        {
        }

        public void Monitor(string pixel)
        {
            this.OS.Monitor = "LG";
        }

        public void Processor(int fast)
        {
            this.OS.Processador = "Intel";
        }

        public void Configuration()
        {
            this.AddPrograms();
        }

        public void MotherBoard()
        {
        }
        public void AddPrograms()
        {
            this.OS.Programs.Add("Officer");
            this.OS.Programs.Add("Chromer");
            this.OS.Programs.Add("Visual Studio");
            this.OS.Programs.Add("Sql Server");
            this.OS.Programs.Add("Postman");
        }

        public string Info()
        {
            var information = "Consumer Memory" + this.OS.ConsumerMemory() +"\n";
            information = information + "Processador" + this.OS.Processador + "\n";
            information = information + "OS" + this.OS.Name + "\n";
            string programs = string.Join("Programs:", this.OS.Programs);
            information = information + "\n" + programs;
            return information;
        }

        public OperationalSystem GetOS()
        {
           return this.OS;
        }
    }
}
