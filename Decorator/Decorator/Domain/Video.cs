using System.IO;

namespace Decorator.Domain
{
    public class Video : LibraryItem
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

        public override string Display()
        {
            var msg ="\nVideo ----- ";
            string.Concat(msg, " Director:", this.Diretor);
            string.Concat(msg, " Director:", this.Title);
            string.Concat(msg, " Director:", this.NumCopies);
            string.Concat(msg, " Director:", this.PlayTime);

            return msg;
        }
    }
}
