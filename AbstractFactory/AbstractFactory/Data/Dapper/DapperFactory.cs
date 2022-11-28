using AbstractFactory.Data.Interface;

namespace AbstractFactory.Data.Dapper
{
    public class DapperFactory : DbFactory
    {
        public override DbCommand CreateCommand()
        {
            throw new NotImplementedException();
        }

        public override DbConnection CreateConnection()
        {
            throw new NotImplementedException();
        }
    }
}
