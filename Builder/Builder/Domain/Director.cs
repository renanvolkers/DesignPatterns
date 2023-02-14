namespace Builder.Domain
{
    public class Director
    {
        public void OperationalSystemWindows(IBuilder builder)
        {
            builder.Reset();
            builder.Name("Windows 10");
            builder.Configuration();
            builder.ConfigWireless();
            builder.Processor(12);
            builder.ConfigAudio();
            builder.Monitor("34y");
            builder.MotherBoard();
            builder.Video();
        }

        public void OperationalSystemLinux(IBuilder builder)
        {
            builder.Reset();
            builder.Name("Linux XX");
            builder.Configuration();
            builder.ConfigWireless();
            builder.Processor(12);
            builder.ConfigAudio();
            builder.Monitor("34y");
            builder.MotherBoard();
            builder.Raw();
            builder.USB();
            builder.Video();
        }

        public void Buildcomputer(IBuilder builder)
        {
            builder.Reset();
            builder.Name("Windows 10");
            builder.Configuration();
            builder.Raw();
            builder.USB();
            builder.Video();
            builder.MotherBoard();
           
        }

    }
}
