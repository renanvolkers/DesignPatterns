using AbstractFactory.Data.Interface;

namespace AbstractFactory.Data.Dapper
{
    public abstract class SqlFactory : DbFactory
    {
        //    //Concrete Factory
        public override DbConnection CreateConnection()
        {
            /* The class here got encapsul */
            return new SqlConnection();
        }

        public override DbCommand CreateCommand()
        {
            return  new SqlCommand();
        }
    }
}
