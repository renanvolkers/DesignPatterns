using AbstractFactory.Exemple_2.Domain;
using AbstractFactory.Exemple_2.Factories.AbstracFactory;
using AbstractFactory.Exemple_2.Factories.Products;

namespace AbstractFactory.Exemple_2.Factories
{
    public class ContextSqlDBFactory : ManagerDataBaseAbstractFactory
    {
        public override ContextDataBase CreateDbContext()
        {
            return new ContextSqlEE();
        }
    }
}
