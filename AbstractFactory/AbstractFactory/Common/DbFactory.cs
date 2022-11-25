using AbstractFactory.Common.Interface;

namespace AbstractFactory.Common
{
    public abstract class DbFactory
    {
        public abstract DbConnection CreateConnection();

        public abstract DbCommand CreateCommand();
    }
}
