using AbstractFactory.Data.Interface;
namespace AbstractFactory.Data.MongoDb
{
    public class MongoConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("amp amp; amp; amp; quot; Método Open de SQL Connection foi chamado...&amp; amp; amp; amp; quot;");
        }
    }
}
