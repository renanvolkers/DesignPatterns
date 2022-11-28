using AbstractFactory.Data.Interface;

namespace AbstractFactory.Data
{
    public abstract class DbContextFactory
    {
        public abstract DbConnection CreateConnection();

        public abstract DbCommand CreateCommand();
    }
}
