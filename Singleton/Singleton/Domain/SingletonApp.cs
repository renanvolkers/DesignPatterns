namespace Singleton.Domain
{
    public class SingletonApp
    {
        #region Singleton Design Pattern 

        private static SingletonApp _mySingleton;

        private SingletonApp()
        {
            TestSingleton = new List<string>();
        }
        public static SingletonApp GetMySingleton()
        {
            if (_mySingleton == null)
                _mySingleton = new SingletonApp();

            return _mySingleton;
        }
        public List<string> TestSingleton { get; set; }
        #endregion
    }
}
