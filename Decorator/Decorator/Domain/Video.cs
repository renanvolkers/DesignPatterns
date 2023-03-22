namespace Decorator.Domain
{
    public class Video
    {
        private string? Diretor { get; set; }
        private string? Title { get; set; }
        private int PlayTime { get; set; }

        public Video(string director, string  title, int playTime)
        {
            Diretor = director;
            Title = title;
            PlayTime = playTime;
        }

    }
}
