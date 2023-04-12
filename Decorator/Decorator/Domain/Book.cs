namespace Decorator.Domain
{
    public class Book : LibraryItem
    {
        private string Author;
        private string Title;

        public Book(string author, string title)
        {
            this.Author = author;
            this.Title = title;
        }

        public override string Display()
        {
            var msg =Environment.NewLine + "Book ------------- ";
            msg = string.Concat(msg, Author); 
            msg= string.Concat(msg, Title);
           return msg;
        }
    }
}
