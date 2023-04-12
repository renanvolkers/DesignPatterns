
namespace Decorator.Domain
{
    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    public class Decorator : LibraryItem
    {
        protected LibraryItem _libraryItem;
        public void SetComponent(LibraryItem libraryItem)
        {
            this._libraryItem = libraryItem;
        }



        public override string Display()
        {
          return  this._libraryItem.Display();    
        }

    }
}
