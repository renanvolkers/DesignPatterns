﻿namespace Decorator.Domain
{
    /// <summary>
    /// The 'Component' abstract class
    /// </summary>
    public class LibraryItem
    {
        private int _numCopies;
        public int NumCopies
        {
            get { return _numCopies; }
            set { _numCopies = value; }
        }
    }
}
