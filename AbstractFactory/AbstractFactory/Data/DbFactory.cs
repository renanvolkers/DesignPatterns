using AbstractFactory.Data.Interface;

namespace AbstractFactory.Data
{
    public abstract class DbFactory
    {
        public abstract DbConnection CreateConnection();

        public abstract DbCommand CreateCommand();
    }
}
