using AbstractFactory.Common.Interface;

namespace AbstractFactory.Common.SqlServe
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
