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
        public List<string> TestSingleton { get; set; }
        #endregion
    }
}
