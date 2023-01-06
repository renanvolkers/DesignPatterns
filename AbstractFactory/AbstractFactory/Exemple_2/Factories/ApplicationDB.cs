using AbstractFactory.Exemple_2.Domain;
using AbstractFactory.Exemple_2.Factories.AbstracFactory;

namespace AbstractFactory.Exemple_2.Factories
{
    public class ApplicationDB : IApplicationDB
    {
        private ManagerDataBaseAbstractFactory factory;
        private ContextDataBase contextDB;
        public string ConnectionString { get; set; }


        public ApplicationDB(string options)
        {
            if (options == "MongoDB")
            {
                factory = new ContextMongoDBFactory();
                contextDB = factory.CreateDbContext();
            }
            else
            {
                factory = new ContextSqlDBFactory();
                contextDB = factory.CreateDbContext();
            }

        }

    }
}
