namespace Builder.Domain
{
    public class HardwareBuilder : IBuilder
    {
        public Notbook Notbook { get; set; } 
        
        public HardwareBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.Notbook = new Notbook();
        }

        public void ConfigAudio()
        {
            this.Notbook.Audio = "Realtek";
        }

        public void Video()
        {
            
        }

        public void ConfigWireless()
        {
            this.Notbook.Wifi="Share";
        }

        public void Raw()
        {
            this.Notbook.Raw = "MockInter";
        }

        public void USB()
        {
            this.Notbook.Usb="Mouse";
        }

        public void Monitor(string pixel)
        {
            this.Notbook.Monitor = "LG";
        }

        public void Processor(int fast)
        {
            this.Notbook.Processador = "Intel";
        }

        public void Configuration()
        {
            this.FullRaw();
        }
        public void FullRaw()
        {
            this.Notbook.SlotRaw.Add("16gb");
            this.Notbook.SlotRaw.Add("16gb");
            this.Notbook.SlotRaw.Add("16gb");
        }

        public void MotherBoard()
        {
            this.Notbook.MotherBoard = "Asus";
        }

        public string Info()
        {
            var information = "HD" + this.Notbook.HdSsd + "\n";
            information = information + "Model" + this.Notbook.Name + "\n";
            information = information + "Company" + this.Notbook.Company + "\n";
            string slotRaw = string.Join("SlotRaw:", this.Notbook.SlotRaw);
            information = information + "\n" + slotRaw;
            return information;
        }

        public void Name(string name)
        {
            this.Notbook.Name = name;
        }

        public Notbook GetNotbook()
        {
            return this.Notbook;
        }
    }
}
