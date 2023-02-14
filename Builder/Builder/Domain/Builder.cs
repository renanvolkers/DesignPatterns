namespace Builder.Domain
{
    public interface Builder
    {
        public void Reset();
        public void SetAudio();
        public void SetVideo();
        public void SetWirelless();
        public void SetRaw();
        public void SetUSB();
        public void SetMonitor();
        public void SetProcessor();
        public void SetMotherBoard();

    }
}
