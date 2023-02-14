namespace Builder.Domain
{
    public interface IBuilder
    {
        public void Reset();
        public void ConfigAudio();
        public void Name(string name);
        public void Video();
        public void ConfigWireless();
        public void Raw();
        public void USB();
        public void Monitor(string pixel);
        public void Processor(int fast);
        public void Configuration();
        public void MotherBoard();
        public string Info();




    }
}
